using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Tilemaps;
using Random = UnityEngine.Random;

namespace Liver {
    public class SectionSpawner : SerializedMonoBehaviour {
        private enum Kind {
            Space,
            Platform
        }

        public int OffsetX;
        public int OffsetY;
        public Tilemap Grid;
        public TileBase PlatformTile;
        public GameState State;
        
        [ShowInInspector] private Dictionary<Vector2Int, Kind> _kindGrid = new Dictionary<Vector2Int, Kind>();

        private const int _width = 16;
        private const int _height = 9;

        public void Awake() {
            State = FindObjectOfType<GameState>();
        }

        public void Start() {
            Randomize();
            StartCoroutine(Draw());
        }

        private void Randomize() {
            for (int x = -6; x < 6; x++) {
                for (int y = -6; y < 6; x++) {
                    for (var i = 0; i < _width; i++) {
                        for (var j = 0; j < _height; j++) {
                            _kindGrid[new Vector2Int(i + 16 * 16, j * 9)] = (Kind) Random.Range(0, 2);
                        }
                    }
                }
            }
        }

        private IEnumerator Draw() {
            yield return new WaitForSeconds(5);
            foreach (var vec in _kindGrid.Keys) {
                ProcessGridLocation(vec);
            }
        }

        private void ProcessGridLocation(Vector2Int vec) {
            var item = _kindGrid[vec];
            var tileVec = new Vector3Int(vec.x + OffsetX, vec.y + OffsetY, 0);
            switch (item) {
                case Kind.Platform: {
                    Grid.SetTile(tileVec, PlatformTile);
                    break;
                }
                case Kind.Space: {
                    if (Grid.GetTile(tileVec)) {
                        var platform = Grid.GetTile(tileVec);
                        Destroy(platform);
                    }

                    break;
                }
                default: {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}