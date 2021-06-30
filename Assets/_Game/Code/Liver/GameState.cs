using UniRx;
using System;
using Sirenix.OdinInspector;

namespace Liver {
    public class GameState : SerializedMonoBehaviour {
        public static GameState Instance;
        
        public FloatReactiveProperty Bottom = new FloatReactiveProperty(0f);
        public FloatReactiveProperty Left = new FloatReactiveProperty(0f);
        public FloatReactiveProperty Right = new FloatReactiveProperty(0f);
        public FloatReactiveProperty Top = new FloatReactiveProperty(0f);
        public ReactiveCollection<Platform> Platforms = new ReactiveCollection<Platform>();

        public void Awake() {
            if (Instance != null) {
                throw new Exception("GameState Instance is already set");
            }
            
            Instance = this;
        }
    }
}