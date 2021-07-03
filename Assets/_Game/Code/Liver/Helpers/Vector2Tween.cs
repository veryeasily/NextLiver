using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Liver.Helpers {
    [Serializable]
    public class Vector2Tween : SerializedMonoBehaviour {
        public bool ShouldRunOnStart;
        public DOGetter<Vector2> Getter;
        public DOSetter<Vector2> Setter;
        public float Duration;
        public Vector2 StartValue;
        public Vector2 EndValue;
        public AnimationCurveReference Ease;
        public GameObjectEventReference OnComplete;

        public void Start() {
            if (ShouldRunOnStart) {
                Run();
            }
        }

        public TweenerCore<Vector2, Vector2, VectorOptions> Run() {
            Setter.Invoke(StartValue);
            var tween = DOTween.To(Getter, Setter, EndValue, Duration).SetEase(Ease.Value);
            
            if (OnComplete.Event != null) {
                tween.OnComplete(() => OnComplete.Event.Raise(gameObject));
            }

            return tween;
        }
    }
}