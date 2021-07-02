using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Vector3IntPair`. Inherits from `AtomEventReferenceListener&lt;Vector3IntPair, Vector3IntPairEvent, Vector3IntPairEventReference, Vector3IntPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector3IntPair Event Reference Listener")]
    public sealed class Vector3IntPairEventReferenceListener : AtomEventReferenceListener<
        Vector3IntPair,
        Vector3IntPairEvent,
        Vector3IntPairEventReference,
        Vector3IntPairUnityEvent>
    { }
}
