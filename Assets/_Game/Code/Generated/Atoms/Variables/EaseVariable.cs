using UnityEngine;
using System;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Ease`. Inherits from `AtomVariable&lt;Ease, EasePair, EaseEvent, EasePairEvent, EaseEaseFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Ease", fileName = "EaseVariable")]
    public sealed class EaseVariable : AtomVariable<Ease, EasePair, EaseEvent, EasePairEvent, EaseEaseFunction>
    {
        protected override bool ValueEquals(Ease other)
        {
            throw new NotImplementedException();
        }
    }
}
