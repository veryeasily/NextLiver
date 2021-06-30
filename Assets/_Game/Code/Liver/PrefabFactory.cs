using UnityEngine;
using Sirenix.OdinInspector;

namespace Liver {
    public class PrefabFactory : SerializedMonoBehaviour {
        public GameObject Prefab;
        public Transform WorldTransform;

        public GameObject Spawn(Platform cont) {
            var go = Instantiate(Prefab, WorldTransform);
            return go;
        }
    }
}