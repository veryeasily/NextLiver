using DG.Tweening;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine.SceneManagement;

namespace Liver {
    public class LevelManager : SerializedMonoBehaviour {
        public void Start() {
            MessageBroker
                .Default
                .Receive<EndGameMessage>()
                .Subscribe(_ => FinishShowCurtains())
                .AddTo(this);
        }

        private void FinishShowCurtains() {
            DOTween.KillAll();
            SceneManager.LoadScene(SceneManager.GetActiveScene().path);
        }
    }
}