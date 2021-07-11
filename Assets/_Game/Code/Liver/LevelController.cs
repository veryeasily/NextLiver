using DG.Tweening;
using Sirenix.OdinInspector;
using UniRx;
using UnityAtoms.BaseAtoms;
using UnityAtoms.SceneMgmt;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Liver {
    public class LevelController : SerializedMonoBehaviour {
        public GameOverScreen GameOverScreen;
        public SceneFieldConstant Scene;
        public AudioClip BackgroundMusic;
        public BoolReference HasIntroCurtainFade;
        
        private GameObject _musicSource;
        
        public void Start() {
            _musicSource = GameObject.FindWithTag("MusicSource");
            if (_musicSource != null) {
                var comp = _musicSource.GetComponent<AudioSource>();
                comp.clip = BackgroundMusic;
                DontDestroyOnLoad(_musicSource);
                if (!comp.isPlaying) {
                    comp.Play();
                }
            }

            MessageBroker
                .Default
                .Receive<DangerousTile>()
                .Subscribe(_ => RunOutro())
                .AddTo(this);

            RunIntro();
        }

        public void OnEnable() {
            GameOverScreen.OnOutroComplete += OutroComplete;
        }

        public void OnDisable() {
            GameOverScreen.OnOutroComplete -= OutroComplete;
        }

        private void RunIntro() {
            if (HasIntroCurtainFade.Value && GameOverScreen != null) {
                GameOverScreen.RunIntro();
            }
        }

        private void RunOutro() {
            if (HasIntroCurtainFade.Value && GameOverScreen != null) {
                GameOverScreen.RunOutro();
            } else {
                OutroComplete();
            }
        }

        private void OutroComplete() {
            DOTween.KillAll();
            var path = Scene.Value.ScenePath;
            SceneManager.LoadScene(path);
        }
    }
}