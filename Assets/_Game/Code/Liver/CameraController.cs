using Cinemachine;
using Sirenix.OdinInspector;
using UniRx;
using UnityAtoms;
using UnityEngine;

namespace Liver {
    public class CameraController : MonoBehaviour {
        public VirtualCamGrid CamGrid;

        [ShowInInspector] private Vector3Int _coord = Vector3Int.zero;
        [SerializeField, Required] private Vector3IntVariable _playerPosition;

        public void Start() {
            var cams = FindObjectsOfType<CinemachineVirtualCamera>();
            CamGrid.Clear();
            foreach (var cam in cams) {
                CamGrid.Add(cam);
            }

            _playerPosition.ObserveChange().Subscribe(PlayerMoved).AddTo(this);
        }

        private void PlayerMoved(Vector3Int pos) {
            CamGrid.SetActive(pos);
        }
    }
}