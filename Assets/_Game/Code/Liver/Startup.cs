using DG.Tweening;
using Sirenix.OdinInspector;

namespace Liver {
    public class Startup : SerializedMonoBehaviour {
        public PrefabFactory Factory;

        public void Awake() {
            DOTween.Init();
        }
    }
}