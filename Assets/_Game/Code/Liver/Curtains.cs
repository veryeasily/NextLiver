using DG.Tweening;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using TMPro;
using UniRx;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Liver {
    public class Curtains : SerializedMonoBehaviour {
        [OdinSerialize] private FloatConstant _showSpeed;
        [OdinSerialize] private FloatConstant _hideSpeed;
        [OdinSerialize] private AnimationCurveConstant _showCurve;
        [OdinSerialize] private AnimationCurveConstant _hideCurve;
        [OdinSerialize] private TMP_Text _textComponent;
        [OdinSerialize] private CanvasGroup _canvasGroup;

        public void Start() {
            MessageBroker.Default.Receive<DangerousTile>().Subscribe(ShowCurtains).AddTo(this);
            HideCurtains();
        }

        private void ShowCurtains(object obj) {
            _textComponent.enabled = true;
            _canvasGroup.DOFade(1f, _showSpeed.Value).SetEase(_showCurve.Value).OnComplete(FinishShowCurtains);
        }

        private void HideCurtains() {
            _textComponent.enabled = false;
            _canvasGroup.DOFade(0f, _hideSpeed.Value).SetEase(_hideCurve.Value).OnComplete(FinishHideCurtains);
        }

        private void FinishShowCurtains() {
            MessageBroker.Default.Publish(new EndGameMessage());
        }

        private void FinishHideCurtains() {
        }
    }
}