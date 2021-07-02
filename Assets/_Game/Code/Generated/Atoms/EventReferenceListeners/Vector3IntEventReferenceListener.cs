using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Vector3Int`. Inherits from `AtomEventReferenceListener&lt;Vector3Int, Vector3IntEvent, Vector3IntEventReference, Vector3IntUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector3Int Event Reference Listener")]
    public sealed class Vector3IntEventReferenceListener : AtomEventReferenceListener<
        Vector3Int,
        Vector3IntEvent,
        Vector3IntEventReference,
        Vector3IntUnityEvent>
    { }
}
