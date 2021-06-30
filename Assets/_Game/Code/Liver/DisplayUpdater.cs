using TMPro;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Liver {
    [RequireComponent(typeof(TMP_Text))]
    public class DisplayUpdater : SerializedMonoBehaviour {
        private TMP_Text _text;

        public void OnMovingChanged(Vector2 moving) {
            var str = $"x = {moving.x}, y = {moving.y}!";
            _text.text = str;
        }

        private void Start() {
            _text = GetComponent<TMP_Text>();
        }
    }
}