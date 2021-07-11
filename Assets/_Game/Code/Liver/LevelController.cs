using DG.Tweening;
using Sirenix.OdinInspector;
using UniRx;
using UnityAtoms.BaseAtoms;
using UnityAtoms.SceneMgmt;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Liver {
    public class LevelController : SerializedMonoBehaviour {
        public Curtains Curtains;
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

            var broker = MessageBroker.Default;
            
            broker
                .Receive<DangerousTile>()
                .Subscribe(_ => RunOutro())
                .AddTo(this);
            
            broker
                .Receive<EndGameMessage>()
                .Subscribe(_ => FinishShowCurtains())
                .AddTo(this);

            RunIntro();
        }

        private void RunIntro() {
            if (HasIntroCurtainFade.Value && Curtains != null) {
                Curtains.RunIntro();
            }
        }

        private void RunOutro() {
            if (HasIntroCurtainFade.Value && Curtains != null) {
                Curtains.RunOutro();
            } else {
                FinishShowCurtains();
            }
        }

        private void FinishShowCurtains() {
            DOTween.KillAll();
            var path = Scene.Value.ScenePath;
            SceneManager.LoadScene(path);
        }
    }
}