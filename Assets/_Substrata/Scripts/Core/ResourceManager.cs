using UnityEngine;
using UnityEngine.Events;

namespace Substrata
{
    public class ResourceManager : MonoBehaviour
    {
        private enum ResourceBucket
        {
            None,
            Iron,
            Gold,
            Stone
        }

        public static ResourceManager Instance { get; private set; }

        [SerializeField] private float iron;
        [SerializeField] private float gold;
        [SerializeField] private float stone;

        public UnityEvent OnResourceChanged;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);

            OnResourceChanged ??= new UnityEvent();
        }

        public void AddResource(BlockType type, float amount)
        {
            if (amount <= 0f)
            {
                return;
            }

            switch (GetResourceBucket(type))
            {
                case ResourceBucket.Iron:
                    iron += amount;
                    break;
                case ResourceBucket.Gold:
                    gold += amount;
                    break;
                case ResourceBucket.Stone:
                    stone += amount;
                    break;
                default:
                    return;
            }

            OnResourceChanged?.Invoke();
        }

        public bool SpendResource(BlockType type, float amount)
        {
            if (amount <= 0f)
            {
                return true;
            }

            switch (GetResourceBucket(type))
            {
                case ResourceBucket.Iron:
                    if (iron < amount)
                    {
                        return false;
                    }

                    iron -= amount;
                    break;
                case ResourceBucket.Gold:
                    if (gold < amount)
                    {
                        return false;
                    }

                    gold -= amount;
                    break;
                case ResourceBucket.Stone:
                    if (stone < amount)
                    {
                        return false;
                    }

                    stone -= amount;
                    break;
                default:
                    return false;
            }

            OnResourceChanged?.Invoke();
            return true;
        }

        public float GetResource(BlockType type)
        {
            return GetResourceBucket(type) switch
            {
                ResourceBucket.Iron => iron,
                ResourceBucket.Gold => gold,
                ResourceBucket.Stone => stone,
                _ => 0f
            };
        }

        public void SaveData()
        {
            // TODO: connect to SaveSystem.
        }

        public void LoadData()
        {
            // TODO: connect to SaveSystem.
        }

        private static ResourceBucket GetResourceBucket(BlockType type)
        {
            return type switch
            {
                BlockType.Dirt => ResourceBucket.Iron,
                BlockType.IronOre => ResourceBucket.Iron,
                BlockType.Stone => ResourceBucket.Stone,
                BlockType.HardStone => ResourceBucket.Stone,
                BlockType.BlueRock => ResourceBucket.Stone,
                BlockType.GoldOre => ResourceBucket.Gold,
                _ => ResourceBucket.None
            };
        }
    }
}
