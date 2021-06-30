using System;
using UnityAtoms.BaseAtoms;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Ease`. Inherits from `AtomReference&lt;Ease, EasePair, EaseConstant, EaseVariable, EaseEvent, EasePairEvent, EaseEaseFunction, EaseVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EaseReference : AtomReference<
        Ease,
        EasePair,
        EaseConstant,
        EaseVariable,
        EaseEvent,
        EasePairEvent,
        EaseEaseFunction,
        EaseVariableInstancer>, IEquatable<EaseReference>
    {
        public EaseReference() : base() { }
        public EaseReference(Ease value) : base(value) { }
        public bool Equals(EaseReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Ease other)
        {
            throw new NotImplementedException();
        }
    }
}
