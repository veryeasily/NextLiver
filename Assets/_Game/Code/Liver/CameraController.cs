using Sirenix.OdinInspector;
using UniRx;
using UnityAtoms;
using UnityEngine;

namespace Liver {
    public class CameraController : MonoBehaviour {
        [Required] public VirtualCameras Cameras;
        [Required] public Transform VCamContainer;

        [SerializeField, Required] private Vector3IntVariable _playerPosition;

        public void Start() {
            Cameras.VCamContainer = VCamContainer;
            _playerPosition.ObserveChange().Subscribe(PlayerMoved).AddTo(this);
        }

        private void PlayerMoved(Vector3Int pos) {
            Cameras.SetActiveForPosition(pos);
        }
    }
}