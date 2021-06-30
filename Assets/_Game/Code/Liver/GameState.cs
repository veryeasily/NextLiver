using System;
using UnityEngine;
using Sirenix.OdinInspector;
using UniRx;

namespace Liver {
    public class GameState : SerializedMonoBehaviour {
        public static GameState Instance;
        public Transform PlatformContainer;
        public ReactiveProperty<Vector2> PlayerMovement = new ReactiveProperty<Vector2>();
        public ReactiveCollection<Platform> Platforms= new ReactiveCollection<Platform>();
        public ReactiveCollection<Platform> PlatformViews = new ReactiveCollection<Platform>();

        public void Awake() {
            if (Instance != null) {
                throw new Exception("GameState Instance is already set");
            }
            
            Instance = this;
        }
    }
}