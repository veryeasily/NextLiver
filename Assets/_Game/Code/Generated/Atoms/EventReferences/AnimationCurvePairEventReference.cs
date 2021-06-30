using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `AnimationCurvePair`. Inherits from `AtomEventReference&lt;AnimationCurvePair, AnimationCurveVariable, AnimationCurvePairEvent, AnimationCurveVariableInstancer, AnimationCurvePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AnimationCurvePairEventReference : AtomEventReference<
        AnimationCurvePair,
        AnimationCurveVariable,
        AnimationCurvePairEvent,
        AnimationCurveVariableInstancer,
        AnimationCurvePairEventInstancer>, IGetEvent 
    { }
}
