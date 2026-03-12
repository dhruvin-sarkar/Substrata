using UnityEngine;
using UnityEngine.Events;

namespace Substrata
{
    public class DrillSystem : MonoBehaviour
    {
        private const string DrillTickMethod = nameof(PerformDrillHit);

        [Min(0f)] public float drillDamage = 10f;
        [Min(0.01f)] public float hitsPerSecond = 2f;
        [Min(0f)] public float fuelMax = 100f;
        [Min(0f)] public float fuelCurrent;
        [Min(0f)] public float fuelConsumptionRate = 5f;

        public UnityEvent OnFuelEmpty;

        public bool IsDrilling { get; private set; }

        private int targetX;
        private int targetY;
        private float scheduledHitsPerSecond;

        private void Awake()
        {
            fuelCurrent = fuelMax;
            OnFuelEmpty ??= new UnityEvent();

            if (GameManager.Instance != null)
            {
                GameManager.Instance.RegisterDrillSystem(this);
            }
        }

        private void Start()
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.RegisterDrillSystem(this);
            }
        }

        private void OnDestroy()
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.UnregisterDrillSystem(this);
            }
        }

        private void Update()
        {
            if (!IsDrilling)
            {
                return;
            }

            if (fuelCurrent > 0f)
            {
                fuelCurrent = Mathf.Max(0f, fuelCurrent - (fuelConsumptionRate * Time.deltaTime));
            }

            if (fuelCurrent <= 0f)
            {
                StopDrilling();
                OnFuelEmpty?.Invoke();
                return;
            }

            if (!Mathf.Approximately(scheduledHitsPerSecond, hitsPerSecond))
            {
                ScheduleDrillHits();
            }
        }

        public void StartDrilling(int x, int y)
        {
            if (fuelCurrent <= 0f || GridManager.Instance == null)
            {
                return;
            }

            targetX = x;
            targetY = y;

            if (IsDrilling)
            {
                return;
            }

            IsDrilling = true;
            ScheduleDrillHits();
        }

        public void StopDrilling()
        {
            if (!IsDrilling)
            {
                return;
            }

            IsDrilling = false;
            CancelInvoke(DrillTickMethod);
        }

        public void Refuel(float amount)
        {
            if (amount <= 0f)
            {
                return;
            }

            fuelCurrent = Mathf.Clamp(fuelCurrent + amount, 0f, fuelMax);
        }

        private void ScheduleDrillHits()
        {
            CancelInvoke(DrillTickMethod);

            scheduledHitsPerSecond = Mathf.Max(0.01f, hitsPerSecond);
            float interval = 1f / scheduledHitsPerSecond;
            InvokeRepeating(DrillTickMethod, 0f, interval);
        }

        private void PerformDrillHit()
        {
            if (!IsDrilling || GridManager.Instance == null)
            {
                StopDrilling();
                return;
            }

            GridManager.Instance.DamageBlock(targetX, targetY, Mathf.Max(1, Mathf.RoundToInt(drillDamage)));
            if (GridManager.Instance.GetBlock(targetX, targetY) == BlockType.Empty)
            {
                StopDrilling();
            }
        }
    }
}
