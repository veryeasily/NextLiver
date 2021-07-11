using Cinemachine;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;

namespace Liver {
    [CreateAssetMenu(fileName = "NewVirtualCameras", menuName = "Liver/VirtualCameras")]
    public class VirtualCameras : SerializedScriptableObject {
        public float XOffset;
        
        public float YOffset;
        
        [Required] public GameObject VCamPrefab;
        
        [System.NonSerialized, ShowInInspector] public Transform VCamContainer;
        
        [Required] public GameObjectValueList GameObjects;
        
        [System.NonSerialized] public CinemachineVirtualCamera ActiveVCam;

        public void SetActiveForPosition(Vector3 position) {
            var minX = Mathf.Infinity;
            var minY = Mathf.Infinity;
            var minDist = Mathf.Infinity;

            foreach (var go in GameObjects) {
                var vCam = go.GetComponent<CinemachineVirtualCamera>();
                vCam.Priority = 0;
                var vecDiff = (position - go.transform.position);
                var dist = vecDiff.sqrMagnitude;
                minX = vecDiff.x < minX ? vecDiff.x : minX;
                minY = vecDiff.y < minY ? vecDiff.y : minY;
                if (dist < minDist) {
                    minDist = dist;
                    ActiveVCam = vCam;
                }
            }

            if (minX >= 8 || minY >= 8) {
                var go = Instantiate(VCamPrefab, VCamContainer);
                var newPos = new Vector3(
                    Mathf.Round((position.x - XOffset) / 16f) * 16f + XOffset,
                    Mathf.Round((position.y - YOffset) / 9f) * 9f + YOffset,
                    go.transform.position.z
                );
                go.transform.position = newPos;
                ActiveVCam = go.GetComponent<CinemachineVirtualCamera>();
            }
            ActiveVCam.Priority = 1;
        }
    }
}