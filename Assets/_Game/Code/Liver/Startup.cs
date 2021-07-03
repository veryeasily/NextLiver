using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Liver {
    public class Startup : SerializedMonoBehaviour {
        public void Awake() {
            DOTween.Init().SetCapacity(500, 200);
            DOTween.debugMode = true;
        }

        public void Start() {
            var state = GameState.Instance;
            var cam = Camera.main;
            var bottomPoint = Vector3.zero;
            var topPoint = new Vector3(cam.pixelWidth, cam.pixelHeight, 0f);
            var vec1 = cam.ScreenToWorldPoint(bottomPoint);
            var vec2 = cam.ScreenToWorldPoint(topPoint);
            state.Top.Value = vec2.y;
            state.Right.Value = vec2.x;
            state.Left.Value = vec1.x;
            state.Bottom.Value = vec1.y;
        }
    }
}