using System;
using DG.Tweening;
using DG.Tweening.Core;
using Shapes;
using Sirenix.OdinInspector;
using TMPro;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtoms.SceneMgmt;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Liver {
    public class LevelManager : SerializedMonoBehaviour {
        [SerializeField] private TMP_Text _textComponent;
        [SerializeField] private Curtains _curtains;
        [SerializeField] private Rectangle _fadeInRectangle;
        [SerializeField] private FloatReference _fadeOutTime;
        [SerializeField] private Vector3IntReference _playerPosition;

        public void Awake() {
            DangerousTile.OnHitPlayer += DangerHitPlayer;
        }

        public void Start() {
            if (_fadeInRectangle == null || !_fadeInRectangle.gameObject.activeInHierarchy) {
                return;
            }

            _curtains.OnFinishShowCurtains += FinishShowCurtains;
            _curtains.HideCurtains();
        }

        public void OnDestroy() {
            _curtains.OnFinishShowCurtains -= FinishShowCurtains;
            DangerousTile.OnHitPlayer -= DangerHitPlayer;
        }

        private void FinishShowCurtains() {
            DOTween.KillAll();
            SceneManager.LoadScene(SceneManager.GetActiveScene().path);
        }

        private void DangerHitPlayer(DangerousTile tile) {
            Debug.Log($"DangerHitPlayer {tile}");
            _playerPosition.Value = Vector3Int.zero;
            DOTween.KillAll();
            _curtains.ShowCurtains();
        }
    }
}