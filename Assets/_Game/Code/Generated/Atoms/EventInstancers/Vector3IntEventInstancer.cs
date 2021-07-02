using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Vector3Int`. Inherits from `AtomEventInstancer&lt;Vector3Int, Vector3IntEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Vector3Int Event Instancer")]
    public class Vector3IntEventInstancer : AtomEventInstancer<Vector3Int, Vector3IntEvent> { }
}
