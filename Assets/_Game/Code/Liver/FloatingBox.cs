using System;
using UnityEngine;
using Sirenix.OdinInspector;
using UniRx;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using Random = UnityEngine.Random;

namespace Liver {
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
        [Required] public ColorConstant MinColor;
        [Required] public ColorConstant MaxColor;
        [SerializeField, Required] private FloatingBoxChanger _boxChanger;


        public static FloatingBox Initialize(Transform parent = null) {
            var go = new GameObject("FloatingBox");
            if (parent != null) {
                go.transform.parent = parent;
            }

            return go.AddComponent<FloatingBox>();
        }

        public void Start() {
            NextState();
        }

        private void Randomize() {
            Duration = DurationDistribution.Value.Evaluate(Random.Range(0f, 1f));
            CurrentColor = Color.Lerp(MinColor.Value, MaxColor.Value, Random.Range(0f, 1f));
            var x = Random.Range(Left.Value, Right.Value);
            var y = Random.Range(Top.Value, Bottom.Value);
            Position = new Vector2(x, y);
            Width = Random.Range(MinWidth.Value, MaxWidth.Value);
            Height = Random.Range(MinHeight.Value, MaxHeight.Value);
        }

        public void NextState() {
            Randomize();
            RunChanger();
        }

        private void RunChanger() {
            _boxChanger.SetAndAnimate(Position, Width, Height, CurrentColor, Duration);
        }
    }
}