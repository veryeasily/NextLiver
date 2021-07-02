using System;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;

namespace Liver {
    public class PlatformManager : SerializedMonoBehaviour {
        public static PlatformManager Instance;
        public ReactiveDictionary<Vector3Int, Platform> Platforms;

        public void Awake() {
            if (Instance != null) {
                throw new Exception("Platform Manager Instance already exists");
            }

            Instance = this;
        }
    }
}