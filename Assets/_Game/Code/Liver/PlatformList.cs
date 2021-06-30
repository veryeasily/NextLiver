using UnityEngine;
using Sirenix.OdinInspector;
using UniRx;

namespace Liver {
    [CreateAssetMenu(fileName = "NewPlatformList", menuName = "Liver/PlatformList", order = 0)]
    public class PlatformList : SerializedScriptableObject {
        public ReactiveCollection<Platform> Platforms;
    }
}