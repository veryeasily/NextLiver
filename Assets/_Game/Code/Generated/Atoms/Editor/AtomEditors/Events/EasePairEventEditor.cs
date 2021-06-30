#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using DG.Tweening;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `EasePair`. Inherits from `AtomEventEditor&lt;EasePair, EasePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(EasePairEvent))]
    public sealed class EasePairEventEditor : AtomEventEditor<EasePair, EasePairEvent> { }
}
#endif
