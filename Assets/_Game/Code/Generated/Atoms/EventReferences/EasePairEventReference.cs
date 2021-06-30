using System;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `EasePair`. Inherits from `AtomEventReference&lt;EasePair, EaseVariable, EasePairEvent, EaseVariableInstancer, EasePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EasePairEventReference : AtomEventReference<
        EasePair,
        EaseVariable,
        EasePairEvent,
        EaseVariableInstancer,
        EasePairEventInstancer>, IGetEvent 
    { }
}
