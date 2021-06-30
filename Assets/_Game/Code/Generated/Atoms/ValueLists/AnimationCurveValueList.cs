using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `AnimationCurve`. Inherits from `AtomValueList&lt;AnimationCurve, AnimationCurveEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/AnimationCurve", fileName = "AnimationCurveValueList")]
    public sealed class AnimationCurveValueList : AtomValueList<AnimationCurve, AnimationCurveEvent> { }
}
