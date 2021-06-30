using UnityEngine;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Ease`. Inherits from `AtomValueList&lt;Ease, EaseEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Ease", fileName = "EaseValueList")]
    public sealed class EaseValueList : AtomValueList<Ease, EaseEvent> { }
}
