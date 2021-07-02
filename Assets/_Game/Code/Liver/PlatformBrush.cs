using UnityEngine;
using UnityEditor.Tilemaps;

namespace Liver {
    [CustomGridBrush(false, true, false, "PlatformBrush")]
    [CreateAssetMenu(fileName = "NewPlatformShapeBrush", menuName = "Liver/PlatformBrush")]
    public class PlatformBrush : GameObjectBrush {
        public BrushCell GetCell(Vector3Int brushPosition) {
            return GetCell(brushPosition.x, brushPosition.y, brushPosition.z);
        }
        
        public BrushCell GetCell(int x, int y, int z) {
            return cells[GetCellIndex(x, y, z)];
        }
    }
}