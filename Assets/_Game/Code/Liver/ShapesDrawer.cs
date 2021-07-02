using System;
using System.Collections.Generic;
using Shapes;
// using UnityEngine;

namespace Liver {
    public class ShapesDrawer : ImmediateModeShapeDrawer {
        public static ShapesDrawer Instance;
        public List<Platform> Tiles = new List<Platform>();

        public void Awake() {
            if (Instance != null) {
                throw new Exception("ShapesDrawer Instance was not null");
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