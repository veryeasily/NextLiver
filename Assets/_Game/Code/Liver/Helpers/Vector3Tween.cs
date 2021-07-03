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
    public class Vector3Tween : SerializedMonoBehaviour {
        public bool ShouldRunOnStart;
        public DOGetter<Vector3> Getter;
        public DOSetter<Vector3> Setter;
        public float Duration;
        public Vector3 StartValue;
        public Vector3 EndValue;
        public AnimationCurveReference Ease;
        public GameObjectEventReference OnComplete;

        public void Start() {
            if (ShouldRunOnStart) {
                Run();
            }
        }

        public TweenerCore<Vector3, Vector3, VectorOptions> Run() {
            Setter.Invoke(StartValue);
            var tween = DOTween.To(Getter, Setter, EndValue, Duration).SetEase(Ease.Value);
            
            if (OnComplete.Event != null) {
                tween.OnComplete(() => OnComplete.Event.Raise(gameObject));
            }

            return tween;
        }
    }
}