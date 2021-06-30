using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `AnimationCurve`. Inherits from `SetVariableValue&lt;AnimationCurve, AnimationCurvePair, AnimationCurveVariable, AnimationCurveConstant, AnimationCurveReference, AnimationCurveEvent, AnimationCurvePairEvent, AnimationCurveVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/AnimationCurve", fileName = "SetAnimationCurveVariableValue")]
    public sealed class SetAnimationCurveVariableValue : SetVariableValue<
        AnimationCurve,
        AnimationCurvePair,
        AnimationCurveVariable,
        AnimationCurveConstant,
        AnimationCurveReference,
        AnimationCurveEvent,
        AnimationCurvePairEvent,
        AnimationCurveAnimationCurveFunction,
        AnimationCurveVariableInstancer>
    { }
}
