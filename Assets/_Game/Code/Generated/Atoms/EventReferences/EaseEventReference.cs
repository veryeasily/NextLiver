using System;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Ease`. Inherits from `AtomEventReference&lt;Ease, EaseVariable, EaseEvent, EaseVariableInstancer, EaseEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EaseEventReference : AtomEventReference<
        Ease,
        EaseVariable,
        EaseEvent,
        EaseVariableInstancer,
        EaseEventInstancer>, IGetEvent 
    { }
}
