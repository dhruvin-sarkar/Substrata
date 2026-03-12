using UnityEngine;

namespace Substrata
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(DrillSystem))]
    public class PlayerController : MonoBehaviour
    {
        [Min(0f)] public float moveSpeed = 5f;

        private Rigidbody2D body;
        private DrillSystem drillSystem;
        private Vector2Int movementIntent;
        private bool isRightMouseHeld;

        private void Awake()
        {
            body = GetComponent<Rigidbody2D>();
            drillSystem = GetComponent<DrillSystem>();

            if (GameManager.Instance != null)
            {
                GameManager.Instance.RegisterPlayerController(this);
            }
        }

        private void Start()
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.RegisterPlayerController(this);
            }
        }

        private void OnDestroy()
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.UnregisterPlayerController(this);
            }
        }

        private void Update()
        {
            isRightMouseHeld = Input.GetMouseButton(1);
            movementIntent = isRightMouseHeld ? GetMouseCardinalIntent() : Vector2Int.zero;

            if (!isRightMouseHeld || movementIntent == Vector2Int.zero)
            {
                drillSystem.StopDrilling();
            }
        }

        private void FixedUpdate()
        {
            if (GridManager.Instance == null || movementIntent == Vector2Int.zero || !isRightMouseHeld)
            {
                body.linearVelocity = Vector2.zero;
                return;
            }

            Vector2Int currentGrid = GridManager.Instance.WorldToGridPosition(transform.position);
            if (currentGrid.x == int.MinValue)
            {
                body.linearVelocity = Vector2.zero;
                drillSystem.StopDrilling();
                return;
            }

            Vector2Int targetGrid = currentGrid + movementIntent;
            if (targetGrid.x < 0 || targetGrid.x >= GridManager.GridWidth || targetGrid.y < 0 || targetGrid.y >= GridManager.GridHeight)
            {
                body.linearVelocity = Vector2.zero;
                drillSystem.StopDrilling();
                return;
            }

            BlockType targetBlock = GridManager.Instance.GetBlock(targetGrid.x, targetGrid.y);

            if (targetBlock == BlockType.Empty)
            {
                drillSystem.StopDrilling();

                Vector2 targetPosition = body.position + ((Vector2)movementIntent * moveSpeed * Time.fixedDeltaTime);
                body.MovePosition(targetPosition);
                return;
            }

            body.linearVelocity = Vector2.zero;
            drillSystem.StartDrilling(targetGrid.x, targetGrid.y);
        }

        private Vector2Int GetMouseCardinalIntent()
        {
            Camera activeCamera = Camera.main;
            if (activeCamera == null)
            {
                return Vector2Int.zero;
            }

            Vector3 mouseWorld = activeCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 delta = mouseWorld - transform.position;

            if (delta.sqrMagnitude <= 0.0001f)
            {
                return Vector2Int.zero;
            }

            if (Mathf.Abs(delta.x) >= Mathf.Abs(delta.y))
            {
                return delta.x >= 0f ? Vector2Int.right : Vector2Int.left;
            }

            return delta.y >= 0f ? Vector2Int.up : Vector2Int.down;
        }
    }
}
