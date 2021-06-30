#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Ease`. Inherits from `AtomDrawer&lt;EaseVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(EaseVariable))]
    public class EaseVariableDrawer : VariableDrawer<EaseVariable> { }
}
#endif
