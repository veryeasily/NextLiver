using Sirenix.OdinInspector;
using TMPro;
using UniRx;
using UnityEngine;

namespace Liver {
    public class DialogueManager : SerializedMonoBehaviour {
        public TMP_Text TextComponent;

        public void Start() {
            GameState.Instance.CurrentTile.Subscribe(PlayerEnterPlatform).AddTo(this);
        }

        public void PlayerEnterPlatform(GameObject platformGo) {
            if (platformGo == null) return;

            var platform = platformGo.GetComponent<Platform>();
            if (platform == null) return;

            var text = platform.BoxText.Value;
            if (!string.IsNullOrEmpty(text)) {
                TextComponent.text = text;
            }
        }
    }
}