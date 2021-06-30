using UnityEngine;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Ease`. Inherits from `AtomEventReferenceListener&lt;Ease, EaseEvent, EaseEventReference, EaseUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Ease Event Reference Listener")]
    public sealed class EaseEventReferenceListener : AtomEventReferenceListener<
        Ease,
        EaseEvent,
        EaseEventReference,
        EaseUnityEvent>
    { }
}
