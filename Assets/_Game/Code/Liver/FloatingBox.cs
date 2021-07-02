using System;
using DG.Tweening;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using Random = UnityEngine.Random;

namespace Liver {
    [RequireComponent(typeof(Shapes.Rectangle))]
    public class FloatingBox : SerializedMonoBehaviour {
        public float Duration = 1f;
        public Color CurrentColor = Color.red;

        public FloatReference Left;
        public FloatReference Right;
        public FloatReference Top;
        public FloatReference Bottom;
        public FloatReference MaxWidth;
        public FloatReference MinWidth;
        public FloatReference MaxHeight;
        public FloatReference MinHeight;
        public AnimationCurveReference DurationDistribution;
        public float Width = 1f;
        public float Height = 1f;
        public Vector2 Position = Vector2.zero;
        public EaseReference Curve;

        private Shapes.Rectangle _rectangle;
        

        public static FloatingBox Initialize(Transform parent = null) {
            var go = new GameObject("FloatingBox");
            if (parent != null) {
                go.transform.parent = parent;
            }
            return go.AddComponent<FloatingBox>();
        }

        public void Start() {
            _rectangle = GetComponent<Shapes.Rectangle>();
            NextState();
        }

        public void OnDestroy() {
            DOTween.Kill(this);
        }

        private void Randomize() {
            Duration = DurationDistribution.Value.Evaluate(Random.Range(0f, 1f));
            CurrentColor = Color.HSVToRGB(0f, 0f, Random.Range(0f, 1f));
            var x = Random.Range(Left.Value, Right.Value);
            var y = Random.Range(Top.Value, Bottom.Value);
            Position = new Vector2(x, y);
            Width = Random.Range(MinWidth.Value, MaxWidth.Value);
            Height = Random.Range(MinHeight.Value, MaxHeight.Value);
        }

        private void NextState() {
            Randomize();
            Animate();
        }

        private void Animate() {
            var seq = DOTween.Sequence();
            seq.Join(MakeHeightTween());
            seq.Join(MakeWidthTween());
            seq.Join(MakeColorTween());
            seq.Join(MakeTransformTween());
            seq.OnComplete(() => NextState());
            seq.SetEase(Curve.Value);
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