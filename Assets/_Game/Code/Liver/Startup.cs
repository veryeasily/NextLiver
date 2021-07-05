using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Liver {
    public class Startup : SerializedMonoBehaviour {
        public void Awake() {
            DOTween.Init().SetCapacity(500, 200);
            DOTween.debugMode = true;
        }
    }
}