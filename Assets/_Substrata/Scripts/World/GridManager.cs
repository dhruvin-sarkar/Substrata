using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Substrata
{
    public class GridManager : MonoBehaviour
    {
        [Serializable]
        public class BlockMapping
        {
            public BlockType blockType;
            public TileBase tile;
            public BlockData data;
        }

        [Serializable]
        public class OreRule
        {
            public BlockType oreType;
            [Range(0f, 1f)] public float spawnChance = 0.05f;
            [Min(0)] public int minDepthRow;
            [Min(0)] public int maxDepthRow = GridHeight - 1;
        }

        public const int GridWidth = 40;
        public const int GridHeight = 150;

        public static GridManager Instance { get; private set; }

        [SerializeField] private Tilemap tilemap;
        [SerializeField] private List<BlockMapping> blockMappings = new List<BlockMapping>();
        [SerializeField] private List<OreRule> oreRules = new List<OreRule>
        {
            new OreRule { oreType = BlockType.IronOre, spawnChance = 0.08f, minDepthRow = 0, maxDepthRow = 50 },
            new OreRule { oreType = BlockType.GoldOre, spawnChance = 0.06f, minDepthRow = 51, maxDepthRow = 100 },
            new OreRule { oreType = BlockType.FuelRock, spawnChance = 0.04f, minDepthRow = 101, maxDepthRow = 149 }
        };

        private readonly Dictionary<BlockType, BlockMapping> blockMappingLookup = new Dictionary<BlockType, BlockMapping>();

        public BlockType[,] grid { get; private set; }
        public int[,] currentHealth { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            RebuildBlockMappingLookup();
            EnsureGridArrays();
        }

        public void GenerateWorld()
        {
            EnsureGridArrays();
            RebuildBlockMappingLookup();

            if (tilemap != null)
            {
                tilemap.ClearAllTiles();
            }

            for (int y = 0; y < GridHeight; y++)
            {
                for (int x = 0; x < GridWidth; x++)
                {
                    BlockType blockType = GetBaseBlockTypeForDepth(y);

                    for (int i = 0; i < oreRules.Count; i++)
                    {
                        OreRule rule = oreRules[i];
                        if (!IsOreRuleAllowed(rule))
                        {
                            continue;
                        }

                        if (y < rule.minDepthRow || y > rule.maxDepthRow)
                        {
                            continue;
                        }

                        if (UnityEngine.Random.value <= rule.spawnChance)
                        {
                            blockType = rule.oreType;
                        }
                    }

                    SetBlock(x, y, blockType);
                }
            }
        }

        public BlockType GetBlock(int x, int y)
        {
            if (!IsWithinBounds(x, y) || grid == null)
            {
                return BlockType.Empty;
            }

            return grid[x, y];
        }

        public void DamageBlock(int x, int y, int damage)
        {
            if (damage <= 0 || !IsWithinBounds(x, y))
            {
                return;
            }

            BlockType blockType = GetBlock(x, y);
            if (blockType == BlockType.Empty)
            {
                return;
            }

            if (currentHealth[x, y] <= 0)
            {
                currentHealth[x, y] = GetMaxHealth(blockType);
            }

            currentHealth[x, y] -= damage;
            if (currentHealth[x, y] <= 0)
            {
                DestroyBlock(x, y);
            }
        }

        public void DestroyBlock(int x, int y)
        {
            if (!IsWithinBounds(x, y))
            {
                return;
            }

            BlockType blockType = GetBlock(x, y);
            if (blockType == BlockType.Empty)
            {
                return;
            }

            BlockMapping mapping = GetBlockMapping(blockType);
            if (mapping != null && mapping.data != null && mapping.data.restoresFuel)
            {
                GameManager.Instance?.DrillSystem?.Refuel(mapping.data.resourceValue);
            }
            else
            {
                ResourceManager.Instance?.AddResource(blockType, GetResourceValue(blockType));
            }

            grid[x, y] = BlockType.Empty;
            currentHealth[x, y] = 0;

            if (tilemap != null)
            {
                tilemap.SetTile(GridToCellPosition(x, y), null);
            }
        }

        public Vector3Int GridToCellPosition(int x, int y)
        {
            return new Vector3Int(x, -y, 0);
        }

        public Vector2Int WorldToGridPosition(Vector3 worldPosition)
        {
            if (tilemap == null)
            {
                return Vector2Int.one * int.MinValue;
            }

            Vector3Int cell = tilemap.WorldToCell(worldPosition);
            return new Vector2Int(cell.x, -cell.y);
        }

        private void EnsureGridArrays()
        {
            if (grid == null || grid.GetLength(0) != GridWidth || grid.GetLength(1) != GridHeight)
            {
                grid = new BlockType[GridWidth, GridHeight];
            }

            if (currentHealth == null || currentHealth.GetLength(0) != GridWidth || currentHealth.GetLength(1) != GridHeight)
            {
                currentHealth = new int[GridWidth, GridHeight];
            }
        }

        private void RebuildBlockMappingLookup()
        {
            blockMappingLookup.Clear();

            for (int i = 0; i < blockMappings.Count; i++)
            {
                BlockMapping mapping = blockMappings[i];
                if (mapping == null)
                {
                    continue;
                }

                blockMappingLookup[mapping.blockType] = mapping;
            }
        }

        private void SetBlock(int x, int y, BlockType blockType)
        {
            grid[x, y] = blockType;
            currentHealth[x, y] = GetMaxHealth(blockType);

            if (tilemap == null)
            {
                return;
            }

            TileBase tile = GetTile(blockType);
            tilemap.SetTile(GridToCellPosition(x, y), tile);
        }

        private TileBase GetTile(BlockType blockType)
        {
            return GetBlockMapping(blockType)?.tile;
        }

        private int GetMaxHealth(BlockType blockType)
        {
            BlockData data = GetBlockMapping(blockType)?.data;
            return Mathf.Max(1, data != null ? data.maxHealth : 1);
        }

        private int GetResourceValue(BlockType blockType)
        {
            BlockData data = GetBlockMapping(blockType)?.data;
            return data != null ? Mathf.Max(0, data.resourceValue) : 0;
        }

        private BlockMapping GetBlockMapping(BlockType blockType)
        {
            blockMappingLookup.TryGetValue(blockType, out BlockMapping mapping);
            return mapping;
        }

        private static BlockType GetBaseBlockTypeForDepth(int row)
        {
            if (row <= 10)
            {
                return BlockType.Dirt;
            }

            if (row <= 50)
            {
                return UnityEngine.Random.value < 0.55f ? BlockType.Dirt : BlockType.Stone;
            }

            if (row <= 100)
            {
                return UnityEngine.Random.value < 0.65f ? BlockType.Stone : BlockType.HardStone;
            }

            return UnityEngine.Random.value < 0.8f ? BlockType.BlueRock : BlockType.HardStone;
        }

        private static bool IsOreRuleAllowed(OreRule rule)
        {
            return rule != null && (rule.oreType == BlockType.IronOre || rule.oreType == BlockType.GoldOre || rule.oreType == BlockType.FuelRock);
        }

        private static bool IsWithinBounds(int x, int y)
        {
            return x >= 0 && x < GridWidth && y >= 0 && y < GridHeight;
        }
    }
}
