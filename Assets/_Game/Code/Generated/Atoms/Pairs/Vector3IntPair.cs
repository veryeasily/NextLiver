using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Vector3Int&gt;`. Inherits from `IPair&lt;Vector3Int&gt;`.
    /// </summary>
    [Serializable]
    public struct Vector3IntPair : IPair<Vector3Int>
    {
        public Vector3Int Item1 { get => _item1; set => _item1 = value; }
        public Vector3Int Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Vector3Int _item1;
        [SerializeField]
        private Vector3Int _item2;

        public void Deconstruct(out Vector3Int item1, out Vector3Int item2) { item1 = Item1; item2 = Item2; }
    }
}