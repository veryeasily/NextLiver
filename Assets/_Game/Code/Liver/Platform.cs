using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Shapes;
using Sirenix.OdinInspector;
using UniRx;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Liver {
    [RequireComponent(typeof(Line))]
    public class Platform : SerializedMonoBehaviour {
        public FloatReference NoiseRate;
        public StringReference BoxText;
        public BoolReference HasVisitedColor;
        public ColorReference VisitedColor;
        public GameObjectValueList TriggerGroup;
        public ReactiveProperty<Color> MainColor;

        [Required] public BoolReference Visited;
        [Required] public ColorReference MinColor;
        [Required] public ColorReference MaxColor;
        [Required] public FloatReference MinDelay;
        [Required] public FloatReference MaxDelay;
        [SerializeField] [Required] private Line _line;
        [SerializeField] [Required] private Rectangle _rectangle;
        private CancellationTokenSource _cts = new CancellationTokenSource();

        private Grid _grid;
        [ShowInInspector] private Vector2Int _gridVec;

        [ShowInInspector] private float _noiseVal;

        [field: TabGroup("Location")]
        [field: ShowInInspector]
        [field: ReadOnly]
        [field: PropertyOrder(-1)]
        public Vector3Int Cell { get; private set; }


        public void Start() {
            _grid = FindObjectOfType<Grid>();
            var position = transform.position;
            var toCast = _grid.WorldToCell(position);
            _gridVec = new Vector2Int(toCast.x, toCast.y);
            SectionSpawner.ExistingPlatforms.Add(_gridVec, this);
            Cell = _grid.WorldToCell(position);
            GameState.Instance.ObjectGrid[Cell] = gameObject;
            SyncColor();
            MainColor.Subscribe(_ => SyncColor()).AddTo(this);
            StartLoop();
            GameState.Instance.CurrentTile.Subscribe(OnCurrentTileChange).AddTo(this);
        }

        public void OnDestroy() {
            _cts.Cancel();
        }

        public void OnChangeVisited(bool visited) {
            _cts.Cancel();
            _cts = new CancellationTokenSource();
            StartLoop();
        }

        private void OnCurrentTileChange(GameObject tile) {
            if (tile != gameObject) return;

            Visited.Value = true;
            if (TriggerGroup != null)
                foreach (var go in TriggerGroup)
                    go.GetComponent<Platform>().Visited.Value = true;
        }

        // public void OnChangePlayerPosition(Vector3Int playerCell) {
        //     if (Cell != playerCell) {
        //         return;
        //     }
        //
        //     CurrentPlatform.Value = gameObject;
        //     Visited.Value = true;
        //     if (TriggerGroup != null) {
        //         foreach (var go in TriggerGroup) {
        //             go.GetComponent<Platform>().Visited.Value = true;
        //         }
        //     }
        // }

        private void SyncColor() {
            _line.Color = MainColor.Value;
            _rectangle.Color = MainColor.Value;
        }

        private async void StartLoop() {
            try {
                while (true) {
                    var delay = Random.Range(MinDelay.Value, MaxDelay.Value);
                    await UniTask.Delay(TimeSpan.FromSeconds(delay), cancellationToken: _cts.Token);
                    var vec1 = Random.insideUnitCircle;
                    var vec2 = Random.insideUnitCircle;
                    MainColor.Value = RandomColor();
                    _line.Start = Modify(vec1);
                    _line.End = Modify(vec2);
                }
            } catch (OperationCanceledException) {
            }
        }

        private Color RandomColor() {
            _noiseVal = Mathf.PerlinNoise(Time.time * NoiseRate.Value, 0f);
            var t = Mathf.Abs(_noiseVal);
            var c1 = Visited.Value && HasVisitedColor.Value ? VisitedColor.Value.linear : MinColor.Value.linear;
            var c2 = MaxColor.Value.linear;
            return Color.Lerp(c1, c2, t).gamma;
        }

        private Vector2 Modify(Vector2 vec) {
            if (Mathf.Abs(vec.x) > Mathf.Abs(vec.y))
                vec.x = vec.x > 0 ? 0.5f : -0.5f;
            else
                vec.y = vec.y > 0 ? 0.5f : -0.5f;

            return vec;
        }
    }
}