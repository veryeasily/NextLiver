using UnityEditor.Tilemaps;
using UnityEngine;

namespace Liver {
    [CustomGridBrush(false, true, false, "RectangleShapeBrush")]
    [CreateAssetMenu(fileName = "NewRectangleShapeBrush", menuName = "Liver/RectangleShapeBrush")]
    public class RectangleShapeBrush : GameObjectBrush {
    }
}