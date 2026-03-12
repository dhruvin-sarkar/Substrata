using UnityEngine;
using UnityEngine.Events;

namespace Substrata
{
    public class GameManager : MonoBehaviour
    {
        public enum GameState
        {
            Mining,
            Surface,
            UpgradeMenu
        }

        public static GameManager Instance { get; private set; }

        [field: SerializeField] public GameState CurrentState { get; private set; } = GameState.Surface;

        public UnityEvent OnStateChanged;

        public DrillSystem DrillSystem;
        public PlayerController PlayerController;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);

            OnStateChanged ??= new UnityEvent();
        }

        public void EnterMining()
        {
            ChangeState(GameState.Mining);
        }

        public void EnterSurface()
        {
            ChangeState(GameState.Surface);
        }

        public void OpenUpgradeMenu()
        {
            ChangeState(GameState.UpgradeMenu);
        }

        public void RegisterDrillSystem(DrillSystem drillSystem)
        {
            if (drillSystem == null)
            {
                return;
            }

            DrillSystem = drillSystem;
        }

        public void RegisterPlayerController(PlayerController playerController)
        {
            if (playerController == null)
            {
                return;
            }

            PlayerController = playerController;
        }

        private void ChangeState(GameState newState)
        {
            if (CurrentState == newState)
            {
                return;
            }

            CurrentState = newState;
            OnStateChanged?.Invoke();
        }
    }
}
