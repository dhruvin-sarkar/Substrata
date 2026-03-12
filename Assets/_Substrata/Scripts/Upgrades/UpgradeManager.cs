using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Substrata
{
    public class UpgradeManager : MonoBehaviour
    {
        [Serializable]
        public class Upgrade
        {
            public string upgradeName;
            [TextArea] public string description;
            public BlockType costResource = BlockType.IronOre;
            public float baseCost = 10f;
            public float exponent = 1.5f;
            public int currentLevel;
            public int maxLevel = 5;
            public float valuePerLevel = 1f;
        }

        public static UpgradeManager Instance { get; private set; }

        [SerializeField] private List<Upgrade> upgrades = new List<Upgrade>
        {
            new Upgrade { upgradeName = "DrillDamage", description = "Increase drill damage.", costResource = BlockType.IronOre, baseCost = 10f, maxLevel = 20, valuePerLevel = 2f },
            new Upgrade { upgradeName = "HitsPerSecond", description = "Increase drill hit frequency.", costResource = BlockType.IronOre, baseCost = 15f, maxLevel = 15, valuePerLevel = 0.25f },
            new Upgrade { upgradeName = "FuelMax", description = "Increase maximum fuel.", costResource = BlockType.Stone, baseCost = 20f, maxLevel = 15, valuePerLevel = 10f },
            new Upgrade { upgradeName = "FuelPreservation", description = "Reduce fuel drain while drilling.", costResource = BlockType.Stone, baseCost = 25f, maxLevel = 10, valuePerLevel = 0.35f },
            new Upgrade { upgradeName = "MovementSpeed", description = "Increase travel speed.", costResource = BlockType.IronOre, baseCost = 12f, maxLevel = 10, valuePerLevel = 0.5f },
            new Upgrade { upgradeName = "CritChance", description = "Unlock future critical hit chance scaling.", costResource = BlockType.GoldOre, baseCost = 30f, maxLevel = 10, valuePerLevel = 1f },
            new Upgrade { upgradeName = "CritDamage", description = "Unlock future critical hit damage scaling.", costResource = BlockType.GoldOre, baseCost = 30f, maxLevel = 10, valuePerLevel = 5f },
            new Upgrade { upgradeName = "BlockRadius", description = "Expand future area damage radius.", costResource = BlockType.Stone, baseCost = 40f, maxLevel = 8, valuePerLevel = 1f },
            new Upgrade { upgradeName = "ResourceMultiplier", description = "Boost future ore yields.", costResource = BlockType.GoldOre, baseCost = 50f, maxLevel = 10, valuePerLevel = 0.1f },
            new Upgrade { upgradeName = "OverdriveSpeed", description = "Increase future overdrive speed.", costResource = BlockType.GoldOre, baseCost = 60f, maxLevel = 10, valuePerLevel = 0.5f },
            new Upgrade { upgradeName = "OverdriveRecharge", description = "Increase future overdrive recharge.", costResource = BlockType.GoldOre, baseCost = 60f, maxLevel = 10, valuePerLevel = 0.5f },
            new Upgrade { upgradeName = "MaxOverdrive", description = "Increase future overdrive capacity.", costResource = BlockType.GoldOre, baseCost = 75f, maxLevel = 10, valuePerLevel = 1f },
            new Upgrade { upgradeName = "EmergencyFuel", description = "Add future emergency fuel behavior.", costResource = BlockType.Stone, baseCost = 45f, maxLevel = 5, valuePerLevel = 5f },
            new Upgrade { upgradeName = "ReleasedQuake", description = "Improve future quake ability.", costResource = BlockType.GoldOre, baseCost = 70f, maxLevel = 5, valuePerLevel = 1f },
            new Upgrade { upgradeName = "ThrowDynamite", description = "Improve future dynamite ability.", costResource = BlockType.GoldOre, baseCost = 70f, maxLevel = 5, valuePerLevel = 1f },
            new Upgrade { upgradeName = "AutoDrones", description = "Increase future drone count.", costResource = BlockType.GoldOre, baseCost = 80f, maxLevel = 5, valuePerLevel = 1f },
            new Upgrade { upgradeName = "DroneCritHit", description = "Increase future drone critical hits.", costResource = BlockType.GoldOre, baseCost = 80f, maxLevel = 10, valuePerLevel = 1f },
            new Upgrade { upgradeName = "DroneInventory", description = "Increase future drone carry capacity.", costResource = BlockType.Stone, baseCost = 55f, maxLevel = 10, valuePerLevel = 1f },
            new Upgrade { upgradeName = "AdditionalDrones", description = "Unlock additional future drones.", costResource = BlockType.GoldOre, baseCost = 90f, maxLevel = 5, valuePerLevel = 1f },
            new Upgrade { upgradeName = "OreSpawnRate", description = "Increase future ore spawn tuning.", costResource = BlockType.Stone, baseCost = 65f, maxLevel = 10, valuePerLevel = 0.02f },
            new Upgrade { upgradeName = "CellValueIron", description = "Increase future iron cell value.", costResource = BlockType.IronOre, baseCost = 35f, maxLevel = 15, valuePerLevel = 1f },
            new Upgrade { upgradeName = "CellValueGold", description = "Increase future gold cell value.", costResource = BlockType.GoldOre, baseCost = 45f, maxLevel = 15, valuePerLevel = 1f },
            new Upgrade { upgradeName = "CellValueStone", description = "Increase future stone cell value.", costResource = BlockType.Stone, baseCost = 25f, maxLevel = 15, valuePerLevel = 1f },
            new Upgrade { upgradeName = "XPGain", description = "Increase future XP gain.", costResource = BlockType.GoldOre, baseCost = 50f, maxLevel = 15, valuePerLevel = 0.1f }
        };

        public UnityEvent OnUpgradePurchased;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);

            OnUpgradePurchased ??= new UnityEvent();
        }

        public int GetCurrentCost(string upgradeName)
        {
            Upgrade upgrade = FindUpgrade(upgradeName);
            if (upgrade == null)
            {
                return 0;
            }

            return Mathf.RoundToInt(upgrade.baseCost * Mathf.Pow(upgrade.exponent, upgrade.currentLevel));
        }

        public bool PurchaseUpgrade(string upgradeName)
        {
            Upgrade upgrade = FindUpgrade(upgradeName);
            if (upgrade == null || upgrade.currentLevel >= upgrade.maxLevel)
            {
                return false;
            }

            ResourceManager resourceManager = ResourceManager.Instance;
            if (resourceManager == null)
            {
                return false;
            }

            int currentCost = GetCurrentCost(upgradeName);
            if (!resourceManager.SpendResource(upgrade.costResource, currentCost))
            {
                return false;
            }

            upgrade.currentLevel++;
            ApplyUpgrade(upgrade);
            OnUpgradePurchased?.Invoke();
            return true;
        }

        public void SaveData()
        {
            // TODO: connect to SaveSystem.
        }

        public void LoadData()
        {
            // TODO: connect to SaveSystem.
        }

        private Upgrade FindUpgrade(string upgradeName)
        {
            return upgrades.Find(upgrade => string.Equals(upgrade.upgradeName, upgradeName, StringComparison.Ordinal));
        }

        private void ApplyUpgrade(Upgrade upgrade)
        {
            DrillSystem drillSystem = GameManager.Instance != null ? GameManager.Instance.DrillSystem : null;
            PlayerController playerController = GameManager.Instance != null ? GameManager.Instance.PlayerController : null;

            switch (upgrade.upgradeName)
            {
                case "DrillDamage":
                    if (drillSystem != null)
                    {
                        drillSystem.drillDamage += upgrade.valuePerLevel;
                    }
                    break;

                case "HitsPerSecond":
                    if (drillSystem != null)
                    {
                        drillSystem.hitsPerSecond += upgrade.valuePerLevel;
                    }
                    break;

                case "FuelMax":
                    if (drillSystem != null)
                    {
                        drillSystem.fuelMax += upgrade.valuePerLevel;
                        drillSystem.fuelCurrent = Mathf.Clamp(drillSystem.fuelCurrent + upgrade.valuePerLevel, 0f, drillSystem.fuelMax);
                    }
                    break;

                case "FuelPreservation":
                    if (drillSystem != null)
                    {
                        drillSystem.fuelConsumptionRate = Mathf.Max(0.1f, drillSystem.fuelConsumptionRate - upgrade.valuePerLevel);
                    }
                    break;

                case "MovementSpeed":
                    if (playerController != null)
                    {
                        playerController.moveSpeed += upgrade.valuePerLevel;
                    }
                    break;

                case "CritChance":
                    // TODO: apply once crit system exists.
                    break;

                case "CritDamage":
                    // TODO: apply once crit system exists.
                    break;

                case "BlockRadius":
                    // TODO: apply once area mining exists.
                    break;

                case "ResourceMultiplier":
                    // TODO: apply once resource multiplier system exists.
                    break;

                case "OverdriveSpeed":
                    // TODO: apply once overdrive system exists.
                    break;

                case "OverdriveRecharge":
                    // TODO: apply once overdrive system exists.
                    break;

                case "MaxOverdrive":
                    // TODO: apply once overdrive system exists.
                    break;

                case "EmergencyFuel":
                    // TODO: apply once emergency fuel system exists.
                    break;

                case "ReleasedQuake":
                    // TODO: apply once quake ability exists.
                    break;

                case "ThrowDynamite":
                    // TODO: apply once dynamite ability exists.
                    break;

                case "AutoDrones":
                    // TODO: apply once drone system exists.
                    break;

                case "DroneCritHit":
                    // TODO: apply once drone crit system exists.
                    break;

                case "DroneInventory":
                    // TODO: apply once drone inventory exists.
                    break;

                case "AdditionalDrones":
                    // TODO: apply once drone spawn system exists.
                    break;

                case "OreSpawnRate":
                    // TODO: apply once ore generation modifiers exist.
                    break;

                case "CellValueIron":
                    // TODO: apply once per-cell value scaling exists.
                    break;

                case "CellValueGold":
                    // TODO: apply once per-cell value scaling exists.
                    break;

                case "CellValueStone":
                    // TODO: apply once per-cell value scaling exists.
                    break;

                case "XPGain":
                    // TODO: apply once XP system exists.
                    break;
            }
        }
    }
}
