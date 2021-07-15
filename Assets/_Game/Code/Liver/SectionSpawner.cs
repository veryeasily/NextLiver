using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UniRx;
using UnityEngine;
using UnityEngine.Tilemaps;
using Random = UnityEngine.Random;

namespace Liver {
    public class SectionSpawner : SerializedMonoBehaviour {
        private enum Kind {
            Space,
            Platform
        }

        public static ReactiveDictionary<Vector2Int, Platform> ExistingPlatforms =
            new ReactiveDictionary<Vector2Int, Platform>();

        public int offsetX;
        public int offsetY;
        public Tilemap Grid;
        public TileBase PlatformTile;

        [ShowInInspector] private Dictionary<Vector2Int, Kind> _kindGrid = new Dictionary<Vector2Int, Kind>();

        private const int _width = 16;
        private const int _height = 9;

        public void Awake() {
            Randomize();
            StartCoroutine(Draw());
        }

        private void Randomize() {
            for (var i = 0; i < _width; i++) {
                for (var j = 0; j < _height; j++) {
                    _kindGrid[new Vector2Int(i, j)] = (Kind) Random.Range(0, 2);
                }
            }
        }

        private IEnumerator Draw() {
            yield return new WaitForSeconds(5);
            foreach (var vec in _kindGrid.Keys) {
                var item = _kindGrid[vec];
                var tileVec = new Vector3Int(vec.x + offsetX, vec.y + offsetY, 0);
                if (item == Kind.Platform) {
                    Grid.SetTile(tileVec, PlatformTile);
                } else {
                    Debug.Log($"Empty state for {vec}");
                    if (ExistingPlatforms.ContainsKey(vec)) {
                        var platform = ExistingPlatforms[vec];
                        Destroy(platform.gameObject);
                    }
                }
            }
        }
    }
}