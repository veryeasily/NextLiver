using System;
using Cysharp.Threading.Tasks;
using Shapes;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UniRx;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Liver {
    [RequireComponent(typeof(Line))]
    public class RectTileView : SerializedMonoBehaviour {
        public FloatReference NoiseRate;
        public ColorReference MinColor;
        public ColorReference MaxColor;
        public FloatReference MinDelay;
        public FloatReference MaxDelay;
        public ReactiveProperty<Color> MainColor;

        [OdinSerialize] private Line _line;
        [OdinSerialize] private Rectangle _rectangle;
        [ShowInInspector] private float _noiseVal;

        private static ShapesTileManager _manager => ShapesTileManager.Instance;

        public void Start() {
            if (_manager != null) {
                _manager.Tiles.Add(this);
            }

            SyncColor();
            MainColor.Subscribe(_ => SyncColor());

            StartLoop();
        }

        private void SyncColor() {
            _line.Color = MainColor.Value;
            _rectangle.Color = MainColor.Value;
        }

        private async void StartLoop() {
            while (true) {
                var delay = Random.Range(MinDelay.Value, MaxDelay.Value);
                await UniTask.Delay(TimeSpan.FromSeconds(delay));
                var vec1 = Random.insideUnitCircle;
                var vec2 = Random.insideUnitCircle;
                MainColor.Value = RandomColor();
                _line.Start = Modify(vec1);
                _line.End = Modify(vec2);
            }
        }

        private Color RandomColor() {
            _noiseVal = Mathf.PerlinNoise(Time.time * NoiseRate.Value, 0f);
            var t = Mathf.Abs(_noiseVal);
            var c1 = MinColor.Value.linear;
            var c2 = MaxColor.Value.linear;
            return Color.Lerp(c1, c2, t).gamma;
        }

        private Vector2 Modify(Vector2 vec) {
            if (Mathf.Abs(vec.x) > Mathf.Abs(vec.y)) {
                vec.x = vec.x > 0 ? 0.5f : -0.5f;
            } else {
                vec.y = vec.y > 0 ? 0.5f : -0.5f;
            }

            return vec;
        }
    }
}