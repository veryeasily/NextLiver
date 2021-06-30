using System;
using UnityEngine;
using DG.Tweening;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Ease&gt;`. Inherits from `IPair&lt;Ease&gt;`.
    /// </summary>
    [Serializable]
    public struct EasePair : IPair<Ease>
    {
        public Ease Item1 { get => _item1; set => _item1 = value; }
        public Ease Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Ease _item1;
        [SerializeField]
        private Ease _item2;

        public void Deconstruct(out Ease item1, out Ease item2) { item1 = Item1; item2 = Item2; }
    }
}