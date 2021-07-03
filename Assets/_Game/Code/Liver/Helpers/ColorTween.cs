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
    public class ColorTween : SerializedMonoBehaviour {
        public bool ShouldRunOnStart;
        public DOGetter<Color> Getter;
        public DOSetter<Color> Setter;
        public float Duration;
        public Color StartValue;
        public Color EndValue;
        public AnimationCurveReference Ease;
        public GameObjectEventReference OnComplete;

        public void Start() {
            if (ShouldRunOnStart) {
                Run();
            }
        }

        public TweenerCore<Color, Color, ColorOptions> Run() {
            Setter.Invoke(StartValue);
            var tween = DOTween.To(Getter, Setter, EndValue, Duration).SetEase(Ease.Value);
            
            if (OnComplete.Event != null) {
                tween.OnComplete(() => OnComplete.Event.Raise(gameObject));
            }

            return tween;
        }
    }
}