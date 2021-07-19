// using System.Collections.Generic;
// using System.Linq;
// using Sirenix.OdinInspector;
// using Sirenix.OdinInspector.Editor;
// using Sirenix.Utilities;
// using Sirenix.Utilities.Editor;
// using UnityEditor;
// using UnityEngine;
//
// #if UNITY_EDITOR
// namespace Liver.Editor {
//     public class PlatformEditor : OdinEditorWindow {
//         private Dictionary<Vector3Int, GameObject> _platforms = new Dictionary<Vector3Int, GameObject>();
//         
//         [MenuItem("Tools/Liver/LiverEditorWindow")]
//         private static void OpenWindow() {
//             var window = GetWindow<PlatformEditor>();
//
//             // Nifty little trick to quickly position the window in the middle of the editor.
//             window.position = GUIHelper.GetEditorWindowRect().AlignCenter(700, 700);
//         }
//
//         
//         [TableMatrix(DrawElementMethod = "DrawPlatformElement", SquareCells = true)]
//         public GameObject[,] Platforms;
//         
//         private static GameObject DrawPlatformElement(Rect rect, GameObject go) {
//             var goName = go ? go.name : "";
//             Debug.Log($"INSIDE DrawPlatformElement {goName}");
//             UnityEditor.EditorGUI.DrawRect(rect.Padding(1), go ? Color.red : Color.blue);
//             return go;
//         }
//
//         [OnInspectorInit]
//         private void SyncObjectGrid() {
//             Platforms = new GameObject[6, 6];
//             var platforms = FindObjectsOfType<Platform>();
//             var parentGrid = FindObjectOfType<Grid>();
//             
//             foreach (var platform in platforms) {
//                 _platforms[parentGrid.WorldToCell(platform.transform.position)] = platform.gameObject;
//             }
//
//             for (var i = -5; i < 1; i++) {
//                 for (var j = -3; j < 3; j++) {
//                     var vec = new Vector3Int(i, j, 0);
//                     if (_platforms.ContainsKey(vec)) {
//                         Platforms[i + 5, j + 3] = _platforms[vec];
//                     }
//                 }
//             }
//         }
//     }
// }
// #endif