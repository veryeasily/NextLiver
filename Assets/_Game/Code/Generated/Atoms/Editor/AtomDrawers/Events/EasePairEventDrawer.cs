#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `EasePair`. Inherits from `AtomDrawer&lt;EasePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(EasePairEvent))]
    public class EasePairEventDrawer : AtomDrawer<EasePairEvent> { }
}
#endif
