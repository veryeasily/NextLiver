#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Ease`. Inherits from `AtomDrawer&lt;EaseEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(EaseEvent))]
    public class EaseEventDrawer : AtomDrawer<EaseEvent> { }
}
#endif
