using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

namespace Liver.Helpers {
    [Serializable]
    public class FloatTween : SerializedMonoBehaviour {
        public bool ShouldRunOnStart;
        public DOGetter<float> Getter;
        public DOSetter<float> Setter;
        public float Duration;
        public float StartValue;
        public float EndValue;
        public AnimationCurveReference Ease;
        public GameObjectEventReference OnComplete;

        public void Start() {
            if (ShouldRunOnStart) {
                Run();
            }
        }

        public TweenerCore<float, float, FloatOptions> Run() {
            Setter.Invoke(StartValue);
            var tween = DOTween.To(Getter, Setter, EndValue, Duration).SetEase(Ease.Value);
            
            if (OnComplete.Event != null) {
                tween.OnComplete(() => OnComplete.Event.Raise(gameObject));
            }

            return tween;
        }
    }
}