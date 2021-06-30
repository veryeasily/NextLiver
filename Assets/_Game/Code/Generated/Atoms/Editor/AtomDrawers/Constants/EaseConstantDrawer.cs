#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Ease`. Inherits from `AtomDrawer&lt;EaseConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(EaseConstant))]
    public class EaseConstantDrawer : VariableDrawer<EaseConstant> { }
}
#endif
