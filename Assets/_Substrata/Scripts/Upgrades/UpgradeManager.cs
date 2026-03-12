using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Substrata
{
    public class UpgradeManager : MonoBehaviour
    {
        private struct DrillBaselines
        {
            public float drillDamage;
            public float hitsPerSecond;
            public float fuelMax;
            public float fuelConsumptionRate;
        }

        private struct PlayerBaselines
        {
            public float moveSpeed;
        }

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

        private DrillSystem baselineDrillSource;
        private DrillBaselines drillBaselines;
        private bool hasDrillBaselines;

        private PlayerController baselinePlayerSource;
        private PlayerBaselines playerBaselines;
        private bool hasPlayerBaselines;

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

        private void Start()
        {
            ApplyAllUpgrades();
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

            if (!CanPurchaseLiveUpgrade(upgrade))
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
            ApplyAllUpgrades();
            OnUpgradePurchased?.Invoke();
            return true;
        }

        public void ApplyAllUpgrades()
        {
            DrillSystem drillSystem = GameManager.Instance != null ? GameManager.Instance.DrillSystem : null;
            PlayerController playerController = GameManager.Instance != null ? GameManager.Instance.PlayerController : null;

            if (drillSystem != null)
            {
                CacheDrillBaselines(drillSystem);
            }

            if (playerController != null)
            {
                CachePlayerBaselines(playerController);
            }

            float totalDrillDamage = 0f;
            float totalHitsPerSecond = 0f;
            float totalFuelMax = 0f;
            float totalFuelPreservation = 0f;
            float totalMovementSpeed = 0f;

            for (int i = 0; i < upgrades.Count; i++)
            {
                Upgrade upgrade = upgrades[i];
                if (upgrade == null || upgrade.currentLevel <= 0)
                {
                    continue;
                }

                float totalValue = upgrade.currentLevel * upgrade.valuePerLevel;
                switch (upgrade.upgradeName)
                {
                    case "DrillDamage":
                        totalDrillDamage += totalValue;
                        break;
                    case "HitsPerSecond":
                        totalHitsPerSecond += totalValue;
                        break;
                    case "FuelMax":
                        totalFuelMax += totalValue;
                        break;
                    case "FuelPreservation":
                        totalFuelPreservation += totalValue;
                        break;
                    case "MovementSpeed":
                        totalMovementSpeed += totalValue;
                        break;
                }
            }

            if (drillSystem != null && hasDrillBaselines)
            {
                float previousFuelMax = drillSystem.fuelMax;
                float previousFuelCurrent = drillSystem.fuelCurrent;

                drillSystem.drillDamage = drillBaselines.drillDamage + totalDrillDamage;
                drillSystem.hitsPerSecond = Mathf.Max(0.01f, drillBaselines.hitsPerSecond + totalHitsPerSecond);
                drillSystem.fuelMax = drillBaselines.fuelMax + totalFuelMax;
                drillSystem.fuelConsumptionRate = Mathf.Max(0.1f, drillBaselines.fuelConsumptionRate - totalFuelPreservation);

                float fuelIncrease = Mathf.Max(0f, drillSystem.fuelMax - previousFuelMax);
                drillSystem.fuelCurrent = Mathf.Clamp(previousFuelCurrent + fuelIncrease, 0f, drillSystem.fuelMax);
            }

            if (playerController != null && hasPlayerBaselines)
            {
                playerController.moveSpeed = playerBaselines.moveSpeed + totalMovementSpeed;
            }
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

        private bool CanPurchaseLiveUpgrade(Upgrade upgrade)
        {
            switch (upgrade.upgradeName)
            {
                case "DrillDamage":
                case "HitsPerSecond":
                case "FuelMax":
                case "FuelPreservation":
                    if (GameManager.Instance == null || GameManager.Instance.DrillSystem == null)
                    {
                        Debug.LogWarning($"Cannot purchase {upgrade.upgradeName}: no DrillSystem is registered with GameManager.", this);
                        return false;
                    }
                    return true;

                case "MovementSpeed":
                    if (GameManager.Instance == null || GameManager.Instance.PlayerController == null)
                    {
                        Debug.LogWarning($"Cannot purchase {upgrade.upgradeName}: no PlayerController is registered with GameManager.", this);
                        return false;
                    }
                    return true;
            }

            return true;
        }

        private void CacheDrillBaselines(DrillSystem drillSystem)
        {
            if (hasDrillBaselines && baselineDrillSource == drillSystem)
            {
                return;
            }

            baselineDrillSource = drillSystem;
            drillBaselines = new DrillBaselines
            {
                drillDamage = drillSystem.drillDamage,
                hitsPerSecond = drillSystem.hitsPerSecond,
                fuelMax = drillSystem.fuelMax,
                fuelConsumptionRate = drillSystem.fuelConsumptionRate
            };
            hasDrillBaselines = true;
        }

        private void CachePlayerBaselines(PlayerController playerController)
        {
            if (hasPlayerBaselines && baselinePlayerSource == playerController)
            {
                return;
            }

            baselinePlayerSource = playerController;
            playerBaselines = new PlayerBaselines
            {
                moveSpeed = playerController.moveSpeed
            };
            hasPlayerBaselines = true;
        }
    }
}
