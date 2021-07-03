using System;
using DG.Tweening;
using Shapes;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using TMPro;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Liver {
    public class Curtains : SerializedMonoBehaviour {
        public event Action OnFinishShowCurtains;
        public event Action OnFinishHideCurtains;

        [OdinSerialize] private FloatConstant _showSpeed;
        [OdinSerialize] private FloatConstant _hideSpeed;
        [OdinSerialize] private AnimationCurveConstant _showCurve;
        [OdinSerialize] private AnimationCurveConstant _hideCurve;
        [OdinSerialize] private TMP_Text _textComponent;
        [OdinSerialize] private CanvasGroup _canvasGroup;

        public void ShowCurtains() {
            _textComponent.enabled = true;
            _canvasGroup.DOFade(1f, _showSpeed.Value).SetEase(_showCurve.Value).OnComplete(FinishShowCurtains);
        }

        public void HideCurtains() {
            _textComponent.enabled = false;
            _canvasGroup.DOFade(0f, _hideSpeed.Value).SetEase(_hideCurve.Value).OnComplete(FinishHideCurtains);
        }

        public void FinishShowCurtains() {
            OnFinishShowCurtains?.Invoke();
        }

        public void FinishHideCurtains() {
            OnFinishHideCurtains?.Invoke();
        }
    }
}