using DG.Tweening;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Liver {
    [RequireComponent(typeof(Shapes.Rectangle))]
    public class MovePlatform : SerializedMonoBehaviour {
        public float Duration = 1f;
        public Color CurrentColor = Color.black;

        public float Width = 1f;
        public float Height = 1f;
        public Vector2 Position = new Vector2(1f, 1f);
        
        private Platform _platform;
        private Shapes.Rectangle _rectangle;

        public void Start() {
            _platform = GetComponent<Platform>();
            _rectangle = GetComponent<Shapes.Rectangle>();
            Draw();
        }

        private void AnimateToRandomState() {
            _platform.Randomize();
            Draw();
        }

        private void Draw() {
            Debug.Log($"STARTING ANIMATION {gameObject.GetInstanceID()}");
            var seq = DOTween.Sequence();
            seq.Join(MakeTransformTween());
            seq.Join(MakeColorTween());
            seq.Join(MakeWidthTween());
            seq.Join(MakeHeightTween());
            seq.OnComplete(AnimateToRandomState);
            seq.Play();
        }

        private Tween MakeTransformTween() {
            return transform.DOMove(Position, Duration);
        }

        private Tween MakeColorTween() {
            var r = _rectangle;
            return DOTween.To(() => r.Color, col => r.Color = col, CurrentColor, Duration);
        }

        private Tween MakeWidthTween() {
            var r = _rectangle;
            return DOTween.To(() => r.Width, w => r.Width = w, Width, Duration);
        }

        private Tween MakeHeightTween() {
            var r = _rectangle;
            return DOTween.To(() => r.Height, h => r.Height = h, Height, Duration);
        }
    }
}