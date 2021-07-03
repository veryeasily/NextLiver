using System;
using DG.Tweening;
using Shapes;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

namespace Liver {
    public class FloatingBoxChanger : SerializedMonoBehaviour {
        public FloatReference FillOpacity;
        public GameObjectEventReference AnimationFinish;

        private Vector2 _position = Vector2.zero;
        private float _width = 1f;
        private float _height = 1f;
        private Color _currentColor = Color.red;
        private float _duration = 1f;
        [SerializeField, Required] private EaseReference _curve;
        [SerializeField, Required] private Rectangle _rectangle;
        [SerializeField, Required] private Rectangle _rectangle2;

        public void SetAndAnimate(Vector2 position, float width, float height, Color currentColor, float duration) {
            _position = position;
            _width = width;
            _height = height;
            _currentColor = currentColor;
            _duration = duration;
            Animate();
        }

        private void Animate() {
            DOTween.Kill(this);
            var seq = DOTween.Sequence();
            seq.Join(MakeHeightTween(_rectangle));
            seq.Join(MakeWidthTween(_rectangle));
            seq.Join(MakeColorTween(_rectangle));
            _currentColor.a = FillOpacity.Value;
            seq.Join(MakeHeightTween(_rectangle2));
            seq.Join(MakeWidthTween(_rectangle2));
            seq.Join(MakeColorTween(_rectangle2));
            seq.Join(MakeTransformTween());
            seq.SetEase(_curve.Value);
            seq.OnComplete(() => AnimationFinish.Event.Raise(gameObject));
        }

        private Tween MakeTransformTween() {
            return transform.DOMove(_position, _duration);
        }

        private Tween MakeColorTween(Rectangle rectangle) {
            var r = rectangle;
            return DOTween.To(() => r.Color, col => r.Color = col, _currentColor, _duration);
        }

        private Tween MakeWidthTween(Rectangle rectangle) {
            var r = rectangle;
            return DOTween.To(() => r.Width, w => r.Width = w, _width, _duration);
        }

        private Tween MakeHeightTween(Rectangle rectangle) {
            var r = rectangle;
            return DOTween.To(() => r.Height, h => r.Height = h, _height, _duration);
        }
    }
}