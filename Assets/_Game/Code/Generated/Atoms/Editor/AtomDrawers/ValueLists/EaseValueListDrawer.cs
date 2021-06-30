#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Ease`. Inherits from `AtomDrawer&lt;EaseValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(EaseValueList))]
    public class EaseValueListDrawer : AtomDrawer<EaseValueList> { }
}
#endif
