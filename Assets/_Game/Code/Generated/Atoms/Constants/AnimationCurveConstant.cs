using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Constant of type `AnimationCurve`. Inherits from `AtomBaseVariable&lt;AnimationCurve&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/AnimationCurve", fileName = "AnimationCurveConstant")]
    public sealed class AnimationCurveConstant : AtomBaseVariable<AnimationCurve> { }
}
