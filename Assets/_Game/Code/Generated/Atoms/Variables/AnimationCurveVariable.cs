using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `AnimationCurve`. Inherits from `AtomVariable&lt;AnimationCurve, AnimationCurvePair, AnimationCurveEvent, AnimationCurvePairEvent, AnimationCurveAnimationCurveFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/AnimationCurve", fileName = "AnimationCurveVariable")]
    public sealed class AnimationCurveVariable : AtomVariable<AnimationCurve, AnimationCurvePair, AnimationCurveEvent, AnimationCurvePairEvent, AnimationCurveAnimationCurveFunction>
    {
        protected override bool ValueEquals(AnimationCurve other)
        {
            throw new NotImplementedException();
        }
    }
}
