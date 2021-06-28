using UniRx;
using UnityEngine;
using UnityEngine.InputSystem;
using Sirenix.OdinInspector;

namespace Liver {
    public class Player : SerializedMonoBehaviour {
        public Vector2ReactiveProperty Moving = new Vector2ReactiveProperty(Vector2.zero);

        public void OnMove(InputAction.CallbackContext ctx) {
            Debug.Log("Inside of OnMove!");
            var vec = ctx.ReadValue<Vector2>();
            Debug.Log($"vec = {vec}");
            Moving.Value = vec;
            Debug.Log($"Moving.Value = {Moving.Value}");
        }
    }
}