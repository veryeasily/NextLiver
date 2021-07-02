using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Vector3Int`. Inherits from `AtomEventReference&lt;Vector3Int, Vector3IntVariable, Vector3IntEvent, Vector3IntVariableInstancer, Vector3IntEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3IntEventReference : AtomEventReference<
        Vector3Int,
        Vector3IntVariable,
        Vector3IntEvent,
        Vector3IntVariableInstancer,
        Vector3IntEventInstancer>, IGetEvent 
    { }
}
