using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UniRx;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Liver {
    public class DangerousTile : SerializedMonoBehaviour {
        public FloatConstant Interval;
        public static event Action<DangerousTile> OnHitPlayer;
        private bool _isCurrent;
        [SerializeField] private GameObject _dangerousObject;
        [ShowInInspector] private readonly ReactiveProperty<bool> _isDangerous = new ReactiveProperty<bool>(false);

        public void Start() {
            GameState.Instance.CurrentTile.Subscribe(OnCurrentTileChange).AddTo(this);
            _isDangerous.Subscribe(OnChangeIsDangerous).AddTo(this);
            RunLoop();
        }

        private void OnChangeIsDangerous(bool val) {
            _dangerousObject.SetActive(val);
        }

        private async void RunLoop() {
            try {
                while (true) {
                    await UniTask.Delay(TimeSpan.FromSeconds(Interval.Value), cancellationToken: this.GetCancellationTokenOnDestroy());
                    _isDangerous.Value = !_isDangerous.Value;
                    if (_isCurrent) {
                        OnHitPlayer?.Invoke(this);
                    }
                }
            }
            catch (OperationCanceledException e) {
            }
        }

        private void OnCurrentTileChange(GameObject go) {
            _isCurrent = false;
            if (go != gameObject) return;

            _isCurrent = true;
            if (_isDangerous.Value) {
                OnHitPlayer?.Invoke(this);
            }
        }
    }
}