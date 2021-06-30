using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `AnimationCurve`. Inherits from `AtomEventInstancer&lt;AnimationCurve, AnimationCurveEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/AnimationCurve Event Instancer")]
    public class AnimationCurveEventInstancer : AtomEventInstancer<AnimationCurve, AnimationCurveEvent> { }
}
