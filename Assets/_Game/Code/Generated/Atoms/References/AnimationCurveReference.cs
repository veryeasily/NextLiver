using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `AnimationCurve`. Inherits from `AtomReference&lt;AnimationCurve, AnimationCurvePair, AnimationCurveConstant, AnimationCurveVariable, AnimationCurveEvent, AnimationCurvePairEvent, AnimationCurveAnimationCurveFunction, AnimationCurveVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AnimationCurveReference : AtomReference<
        AnimationCurve,
        AnimationCurvePair,
        AnimationCurveConstant,
        AnimationCurveVariable,
        AnimationCurveEvent,
        AnimationCurvePairEvent,
        AnimationCurveAnimationCurveFunction,
        AnimationCurveVariableInstancer>, IEquatable<AnimationCurveReference>
    {
        public AnimationCurveReference() : base() { }
        public AnimationCurveReference(AnimationCurve value) : base(value) { }
        public bool Equals(AnimationCurveReference other) { return base.Equals(other); }
        protected override bool ValueEquals(AnimationCurve other)
        {
            throw new NotImplementedException();
        }
    }
}
