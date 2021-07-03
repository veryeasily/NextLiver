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
    public class RectTween : SerializedMonoBehaviour {
        public bool ShouldRunOnStart;
        public DOGetter<Rect> Getter;
        public DOSetter<Rect> Setter;
        public float Duration;
        public Rect StartValue;
        public Rect EndValue;
        public AnimationCurveReference Ease;
        public GameObjectEventReference OnComplete;

        public void Start() {
            if (ShouldRunOnStart) {
                Run();
            }
        }

        public TweenerCore<Rect, Rect, RectOptions> Run() {
            Setter.Invoke(StartValue);
            var tween = DOTween.To(Getter, Setter, EndValue, Duration).SetEase(Ease.Value);
            
            if (OnComplete.Event != null) {
                tween.OnComplete(() => OnComplete.Event.Raise(gameObject));
            }

            return tween;
        }
    }
}