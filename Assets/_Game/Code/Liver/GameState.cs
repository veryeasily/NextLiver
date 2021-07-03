using UniRx;
using System;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityEngine;

namespace Liver {
    public class GameState : SerializedMonoBehaviour {
        public static GameState Instance;

        public ReactiveDictionary<Vector3Int, GameObject> ObjectGrid;
        public FloatReactiveProperty Bottom = new FloatReactiveProperty(0f);
        public FloatReactiveProperty Left = new FloatReactiveProperty(0f);
        public FloatReactiveProperty Right = new FloatReactiveProperty(0f);
        public FloatReactiveProperty Top = new FloatReactiveProperty(0f);
        public Vector3IntEventReference PositionChanged;
        public IObservable<GameObject> CurrentTile;

        public void Awake() {
            if (Instance != null) {
                throw new Exception("GameState Instance is already set");
            }

            Instance = this;
            CurrentTile = PositionChanged.Event.Observe()
                .Select(vec => ObjectGrid.ContainsKey(vec) ? ObjectGrid[vec] : null);
        }
    }
}