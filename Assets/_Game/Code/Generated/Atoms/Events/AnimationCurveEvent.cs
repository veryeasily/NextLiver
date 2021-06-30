using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `AnimationCurve`. Inherits from `AtomEvent&lt;AnimationCurve&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/AnimationCurve", fileName = "AnimationCurveEvent")]
    public sealed class AnimationCurveEvent : AtomEvent<AnimationCurve>
    {
    }
}
