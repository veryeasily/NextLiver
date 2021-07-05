using Cysharp.Threading.Tasks;
using DG.Tweening;
using Sirenix.OdinInspector;
using UniRx;
using UnityAtoms.SceneMgmt;
using UnityEngine.SceneManagement;

namespace Liver {
    public class LevelManager : SerializedMonoBehaviour {
        public SceneFieldConstant Scene;
        
        public void Start() {
            MessageBroker
                .Default
                .Receive<EndGameMessage>()
                .Subscribe(_ => FinishShowCurtains())
                .AddTo(this);
        }

        private async void FinishShowCurtains() {
            DOTween.KillAll();
            var path = Scene.Value.ScenePath;
            await SceneManager.UnloadSceneAsync(path).ToUniTask();
            SceneManager.LoadScene(path, LoadSceneMode.Additive);
        }
    }
}