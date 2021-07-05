using System;
using System.Collections.Generic;
using System.Linq;
using Cinemachine;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Liver {
    [CreateAssetMenu(fileName = "NewVirtualCamList", menuName = "Liver/VirtualCamGrid")]
    public class VirtualCamGrid : SerializedScriptableObject {
        public Dictionary<Vector3Int, CinemachineVirtualCamera> Grid;
        public IEnumerable<CinemachineVirtualCamera> Cameras => Grid.Values;

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
            var pos = cam.transform.position;
            var coord = new Vector3Int(
                (int) (pos.x / 20),
                (int) (pos.y / 20),
                0
            );
            Grid[coord] = cam;
        }

        public void Clear() {
            Grid = new Dictionary<Vector3Int, CinemachineVirtualCamera>();
        }
    }
}