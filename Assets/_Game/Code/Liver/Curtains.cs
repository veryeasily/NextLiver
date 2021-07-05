using DG.Tweening;
using Sirenix.OdinInspector;
using TMPro;
using UniRx;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Liver {
    public class Curtains : SerializedMonoBehaviour {
        [TabGroup("Main")] [SerializeField] private BoolReference _hasIntroCurtainFade;

        [TabGroup("Main")] [SerializeField] private TMP_Text _textComponent;

        [TabGroup("Main")] [SerializeField] private CanvasGroup _canvasGroup;

        [TabGroup("Animation")] [SerializeField]
        private FloatConstant _showSpeed;

        [TabGroup("Animation")] [SerializeField]
        private FloatConstant _hideSpeed;

        [TabGroup("Animation")] [SerializeField]
        private AnimationCurveConstant _showCurve;

        [TabGroup("Animation")] [SerializeField]
        private AnimationCurveConstant _hideCurve;

        public void Start() {
            MessageBroker.Default.Receive<DangerousTile>().Subscribe(RunOutro).AddTo(this);
            if (_hasIntroCurtainFade.Value) {
                RunIntro();
            } else {
                FinishIntro();
            }
        }

        private void RunOutro(object obj) {
            _textComponent.enabled = true;
            gameObject.SetActive(false);
            _canvasGroup.DOFade(1f, _showSpeed.Value).SetEase(_showCurve.Value).OnComplete(FinishOutro);
        }

        private void RunIntro() {
            _textComponent.enabled = false;
            gameObject.SetActive(true);
            _canvasGroup.DOFade(0f, _hideSpeed.Value).SetEase(_hideCurve.Value).OnComplete(FinishIntro);
        }

        private void FinishOutro() {
            MessageBroker.Default.Publish(new EndGameMessage());
        }

        private void FinishIntro() {
            gameObject.SetActive(false);
        }
    }
}