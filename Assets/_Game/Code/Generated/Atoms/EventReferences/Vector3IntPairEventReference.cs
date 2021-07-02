using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Vector3IntPair`. Inherits from `AtomEventReference&lt;Vector3IntPair, Vector3IntVariable, Vector3IntPairEvent, Vector3IntVariableInstancer, Vector3IntPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3IntPairEventReference : AtomEventReference<
        Vector3IntPair,
        Vector3IntVariable,
        Vector3IntPairEvent,
        Vector3IntVariableInstancer,
        Vector3IntPairEventInstancer>, IGetEvent 
    { }
}
