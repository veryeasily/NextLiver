using UniRx;
using System;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Liver {
    public class GameState : SerializedMonoBehaviour {
        public static GameState Instance;

        public ReactiveDictionary<Vector3Int, GameObject> ObjectGrid;
        // public FloatReactiveProperty Bottom = new FloatReactiveProperty(0f);
        // public FloatReactiveProperty Left = new FloatReactiveProperty(0f);
        // public FloatReactiveProperty Right = new FloatReactiveProperty(0f);
        // public FloatReactiveProperty Top = new FloatReactiveProperty(0f);
        public FloatReference Bottom;
        public FloatReference Left;
        public FloatReference Right;
        public FloatReference Top;
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

        public void Start() {
            SyncViewport();
            PositionChanged.Event.Observe().Subscribe(_ => SyncViewport()).AddTo(this);
        }

        private void SyncViewport() {
            var cam = Camera.main;
            var adj = cam.transform.position.z * -1f;
            var vec1 = cam.ViewportToWorldPoint(new Vector3(0f, 0f, adj));
            var vec2 = cam.ViewportToWorldPoint(new Vector3(1f, 1f, adj));
            Top.Value = vec2.y;
            Right.Value = vec2.x;
            Left.Value = vec1.x;
            Bottom.Value = vec1.y;
        }
    }
}