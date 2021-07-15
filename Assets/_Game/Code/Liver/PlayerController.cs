using System;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

namespace Liver {
    public class Player : SerializedMonoBehaviour {
        // ReSharper disable once MemberCanBePrivate.Global
        public static Player Instance;
        public FloatReference MoveSpeed;
        public Vector3IntVariable Position;
        public Vector3IntVariable Direction;
        public GameObjectValueList PlatformGameObjects;

        [SerializeField] private Grid _grid;

        public void Start() {
            if (Instance != null) {
                throw new Exception("Player Instance already set");
            }

            Instance = this;
            Position.Value = _grid.WorldToCell(transform.position);
        }

        public void OnDestroy() {
            DOTween.Kill(this);
        }

        public void OnMove(InputAction.CallbackContext ctx) {
            if (!ctx.started || IsMoving()) return;

            var vec = Vector3Int.FloorToInt(ctx.ReadValue<Vector2>());
            Direction.Value = vec;
            HandleDirection(vec);
        }

        public void OnPoint(InputAction.CallbackContext ctx) {
            if (!ctx.performed) return;

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit)) {
                Debug.Log($"Game Object hit = {hit.transform.name}");
            }
        }

        private bool IsMoving() {
            return Direction.Value != Vector3Int.zero;
        }

        private void HandleDirection(Vector3Int dir) {
            if (dir == Vector3Int.zero) return;

            var updateVec = Position.Value + dir;
            var cells = from go in PlatformGameObjects select go.GetComponent<Platform>().Cell;
            if (cells.Contains(updateVec)) {
                var updatePos = _grid.GetCellCenterWorld(updateVec);
                transform.DOMove(updatePos, 1f / MoveSpeed.Value).OnComplete(SyncPosition);
            } else {
                Direction.Value = Vector3Int.zero;
            }
        }

        private void SyncPosition() {
            Direction.Value = Vector3Int.zero;
            Position.Value = _grid.LocalToCell(transform.localPosition);
        }
    }
}