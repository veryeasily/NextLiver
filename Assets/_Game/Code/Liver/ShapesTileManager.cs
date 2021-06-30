using System;
using System.Collections.Generic;
using Shapes;
// using UnityEngine;

namespace Liver {
    public class ShapesTileManager : ImmediateModeShapeDrawer {
        public static ShapesTileManager Instance;
        public List<RectTileView> Tiles = new List<RectTileView>();

        public void Awake() {
            if (Instance != null) {
                throw new Exception("ShapesTileManager Instance was not null");
            }

            Instance = this;
        }

        // public override void DrawShapes(Camera cam) {
        //     using (Draw.Command(cam)) {
        //         foreach (var tile in Tiles) {
        //             var pos = tile.transform.position;
        //             var rect = new Rect(pos.x, pos.y, 1f, 1f);
        //             Draw.Rectangle(rect);
        //         }
        //     }
        // }
    }
}