using DG.Tweening;
using Sirenix.OdinInspector;
using TMPro;
using UniRx;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Liver {
    public class GameOverScreen : SerializedMonoBehaviour {
        public static event System.Action OnIntroComplete;
        public static event System.Action OnOutroComplete;
        
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

        public void RunOutro() {
            _textComponent.enabled = true;
            gameObject.SetActive(true);
            _canvasGroup.DOFade(1f, _showSpeed.Value).SetEase(_showCurve.Value).OnComplete(FinishOutro);
        }

        public void RunIntro() {
            _textComponent.enabled = false;
            gameObject.SetActive(true);
            _canvasGroup.DOFade(0f, _hideSpeed.Value).SetEase(_hideCurve.Value).OnComplete(FinishIntro);
        }

        private void FinishOutro() {
            OnOutroComplete?.Invoke();
        }

        private void FinishIntro() {
            gameObject.SetActive(false);
            OnIntroComplete?.Invoke();
        }
    }
}