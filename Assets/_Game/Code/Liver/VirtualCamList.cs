using System;
using System.Collections.Generic;
using System.Linq;
using Cinemachine;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Liver {
    [CreateAssetMenu(fileName = "NewVirtualCamList", menuName = "Liver/VirtualCamList")]
    public class VirtualCamList : SerializedScriptableObject {
        public List<CinemachineVirtualCamera> Cameras = new List<CinemachineVirtualCamera>();

        public void SetActive(Vector3 pos) {
            var minDistance = float.PositiveInfinity;
            CinemachineVirtualCamera activeCam = null;
            
            foreach (var cam in Cameras) {
                var dist = (cam.transform.position - pos).sqrMagnitude;
                if (dist < minDistance) {
                    minDistance = dist;
                    activeCam = cam;
                }
                cam.Priority = 0;
            }
            activeCam.Priority = 1;
        }

        public void Add(CinemachineVirtualCamera cam) {
            Cameras.Add(cam);
        }

        public void Clear() {
            Cameras.Clear();
        }
    }
}