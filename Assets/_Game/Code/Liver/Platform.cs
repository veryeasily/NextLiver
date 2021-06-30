using UnityEngine;
using Sirenix.OdinInspector;
using UniRx;
using Random = UnityEngine.Random;

namespace Liver {
    [RequireComponent(typeof(Shapes.Rectangle))]
    public class Platform : SerializedMonoBehaviour {
        public FloatReactiveProperty Duration = new FloatReactiveProperty();
        public ColorReactiveProperty CurrentColor = new ColorReactiveProperty();

        public FloatReactiveProperty Width = new FloatReactiveProperty(1f);
        public FloatReactiveProperty Height = new FloatReactiveProperty(1f);
        public Vector2ReactiveProperty Position = new Vector2ReactiveProperty(Vector2.zero);
        
        private static GameState _state => GameState.Instance;
        private Shapes.Rectangle _rectangle;
        

        public static Platform Initialize(Transform parent = null) {
            var go = new GameObject("Platform");
            if (parent != null) {
                go.transform.parent = parent;
            }
            var platform = go.AddComponent<Platform>();
            return platform;
        }

        public void Awake() {
            Randomize();
        }
        
        public void Start() {
            _rectangle = GetComponent<Shapes.Rectangle>();
            _state.PlatformViews.Add(this);
            
            Width.Subscribe(_ => Draw());
            Height.Subscribe(_ => Draw());
            CurrentColor.Subscribe(_ => Draw());
            Position.Subscribe(_ => Draw());
        }

        public void Randomize() {
            Duration.Value = Random.Range(1f, 5f);
            CurrentColor.Value = Random.ColorHSV();
            Width.Value = Random.Range(1f, 5f);
            Height.Value = Random.Range(1f, 5f);
            Position.Value = Random.insideUnitCircle * Random.Range(1f, 3f);
        }

        private void Draw() {
            transform.localPosition = Position.Value;
            
            _rectangle.Width = Width.Value;
            _rectangle.Height = Height.Value;
            _rectangle.Color = CurrentColor.Value;
        }
    }
}