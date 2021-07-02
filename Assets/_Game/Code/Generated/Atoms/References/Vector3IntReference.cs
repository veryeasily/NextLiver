using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Vector3Int`. Inherits from `EquatableAtomReference&lt;Vector3Int, Vector3IntPair, Vector3IntConstant, Vector3IntVariable, Vector3IntEvent, Vector3IntPairEvent, Vector3IntVector3IntFunction, Vector3IntVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3IntReference : EquatableAtomReference<
        Vector3Int,
        Vector3IntPair,
        Vector3IntConstant,
        Vector3IntVariable,
        Vector3IntEvent,
        Vector3IntPairEvent,
        Vector3IntVector3IntFunction,
        Vector3IntVariableInstancer>, IEquatable<Vector3IntReference>
    {
        public Vector3IntReference() : base() { }
        public Vector3IntReference(Vector3Int value) : base(value) { }
        public bool Equals(Vector3IntReference other) { return base.Equals(other); }
    }
}
