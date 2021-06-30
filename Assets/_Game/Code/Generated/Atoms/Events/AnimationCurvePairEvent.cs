using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `AnimationCurvePair`. Inherits from `AtomEvent&lt;AnimationCurvePair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/AnimationCurvePair", fileName = "AnimationCurvePairEvent")]
    public sealed class AnimationCurvePairEvent : AtomEvent<AnimationCurvePair>
    {
    }
}
