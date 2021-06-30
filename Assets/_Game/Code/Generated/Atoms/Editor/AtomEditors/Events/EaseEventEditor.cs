#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using DG.Tweening;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Ease`. Inherits from `AtomEventEditor&lt;Ease, EaseEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(EaseEvent))]
    public sealed class EaseEventEditor : AtomEventEditor<Ease, EaseEvent> { }
}
#endif
