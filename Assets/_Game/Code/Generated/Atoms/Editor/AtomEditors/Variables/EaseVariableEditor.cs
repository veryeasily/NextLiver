using UnityEditor;
using UnityAtoms.Editor;
using DG.Tweening;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Ease`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(EaseVariable))]
    public sealed class EaseVariableEditor : AtomVariableEditor<Ease, EasePair> { }
}
