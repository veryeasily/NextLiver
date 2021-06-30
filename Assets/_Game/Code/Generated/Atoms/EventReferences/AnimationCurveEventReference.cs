using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `AnimationCurve`. Inherits from `AtomEventReference&lt;AnimationCurve, AnimationCurveVariable, AnimationCurveEvent, AnimationCurveVariableInstancer, AnimationCurveEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AnimationCurveEventReference : AtomEventReference<
        AnimationCurve,
        AnimationCurveVariable,
        AnimationCurveEvent,
        AnimationCurveVariableInstancer,
        AnimationCurveEventInstancer>, IGetEvent 
    { }
}
