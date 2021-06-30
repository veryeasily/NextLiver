using UnityEngine;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `EasePair`. Inherits from `AtomEventReferenceListener&lt;EasePair, EasePairEvent, EasePairEventReference, EasePairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/EasePair Event Reference Listener")]
    public sealed class EasePairEventReferenceListener : AtomEventReferenceListener<
        EasePair,
        EasePairEvent,
        EasePairEventReference,
        EasePairUnityEvent>
    { }
}
