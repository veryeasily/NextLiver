using Cinemachine;
using Sirenix.OdinInspector;
using UniRx;
using UnityAtoms;
using UnityEngine;

namespace Liver {
    public class CameraController : MonoBehaviour {
        [Required] public VirtualCamList CamList;

        [SerializeField, Required] private Vector3IntVariable _playerPosition;

        public void Start() {
            var cams = FindObjectsOfType<CinemachineVirtualCamera>();
            CamList.Clear();
            foreach (var cam in cams) {
                CamList.Add(cam);
            }

            _playerPosition.ObserveChange().Subscribe(PlayerMoved).AddTo(this);
        }

        private void PlayerMoved(Vector3Int pos) {
            CamList.SetActive(pos);
        }
    }
}