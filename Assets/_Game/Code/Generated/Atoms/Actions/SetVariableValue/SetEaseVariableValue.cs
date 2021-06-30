using UnityEngine;
using UnityAtoms.BaseAtoms;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Ease`. Inherits from `SetVariableValue&lt;Ease, EasePair, EaseVariable, EaseConstant, EaseReference, EaseEvent, EasePairEvent, EaseVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Ease", fileName = "SetEaseVariableValue")]
    public sealed class SetEaseVariableValue : SetVariableValue<
        Ease,
        EasePair,
        EaseVariable,
        EaseConstant,
        EaseReference,
        EaseEvent,
        EasePairEvent,
        EaseEaseFunction,
        EaseVariableInstancer>
    { }
}
