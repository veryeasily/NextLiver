using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Sirenix.OdinInspector;
using UniRx;

namespace Liver {
    public class Player : SerializedMonoBehaviour {
        public ReactiveProperty<Vector2> Moving;
        public static Player Instance;

        public void Start() {
            if (Instance != null) {
                throw new Exception("Player Instance already set");
            }
            Instance = this;
        }

        public void OnMove(InputAction.CallbackContext ctx) {
            var vec = ctx.ReadValue<Vector2>();
            Moving.Value = vec;
        }
    }
}