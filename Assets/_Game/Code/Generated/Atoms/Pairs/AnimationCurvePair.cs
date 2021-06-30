using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;AnimationCurve&gt;`. Inherits from `IPair&lt;AnimationCurve&gt;`.
    /// </summary>
    [Serializable]
    public struct AnimationCurvePair : IPair<AnimationCurve>
    {
        public AnimationCurve Item1 { get => _item1; set => _item1 = value; }
        public AnimationCurve Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private AnimationCurve _item1;
        [SerializeField]
        private AnimationCurve _item2;

        public void Deconstruct(out AnimationCurve item1, out AnimationCurve item2) { item1 = Item1; item2 = Item2; }
    }
}