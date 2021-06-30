using UnityEngine;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Ease`. Inherits from `AtomEvent&lt;Ease&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Ease", fileName = "EaseEvent")]
    public sealed class EaseEvent : AtomEvent<Ease>
    {
    }
}
