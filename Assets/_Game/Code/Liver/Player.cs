using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UniRx;
using UnityAtoms.BaseAtoms;

namespace Liver {
    public class Player : SerializedMonoBehaviour {
        public static Player Instance;
        public FloatReference MoveSpeed;
        public Vector3Reference Position;
        public ReactiveProperty<Vector3Int> Direction;
        
        [OdinSerialize] private Grid _grid;

        public void Start() {
            if (Instance != null) {
                throw new Exception("Player Instance already set");
            }
            Instance = this;
            Position.Value = _grid.LocalToCell(transform.localPosition);
            Direction.Subscribe(HandleDirection);
        }

        public void OnMove(InputAction.CallbackContext ctx) {
            if (!ctx.started) return;
            var vec = ctx.ReadValue<Vector2>();
            Direction.Value = new Vector3Int((int)Mathf.Round(vec.x), (int)Mathf.Round(vec.y), 0);
        }

        private void HandleDirection(Vector3Int dir) {
            if (dir == Vector3Int.zero) return;
            
            var updateVec = Position.Value + Direction.Value;
            var updatePos = _grid.CellToLocal(Vector3Int.FloorToInt(updateVec)) + 0.5f * Vector3.one;
            transform.DOMove(updatePos, 1 / MoveSpeed.Value).OnComplete(SyncPosition);
        }

        private void SyncPosition() {
            Direction.Value = Vector3Int.zero;
            Position.Value = _grid.LocalToCell(transform.localPosition);
        }
    }
}