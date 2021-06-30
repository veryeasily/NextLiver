using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `AnimationCurve`. Inherits from `AtomVariableInstancer&lt;AnimationCurveVariable, AnimationCurvePair, AnimationCurve, AnimationCurveEvent, AnimationCurvePairEvent, AnimationCurveAnimationCurveFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/AnimationCurve Variable Instancer")]
    public class AnimationCurveVariableInstancer : AtomVariableInstancer<
        AnimationCurveVariable,
        AnimationCurvePair,
        AnimationCurve,
        AnimationCurveEvent,
        AnimationCurvePairEvent,
        AnimationCurveAnimationCurveFunction>
    { }
}
