using UnityEngine;
using UnityAtoms.BaseAtoms;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Ease`. Inherits from `AtomVariableInstancer&lt;EaseVariable, EasePair, Ease, EaseEvent, EasePairEvent, EaseEaseFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Ease Variable Instancer")]
    public class EaseVariableInstancer : AtomVariableInstancer<
        EaseVariable,
        EasePair,
        Ease,
        EaseEvent,
        EasePairEvent,
        EaseEaseFunction>
    { }
}
