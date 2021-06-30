using UnityEngine;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `EasePair`. Inherits from `AtomEvent&lt;EasePair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/EasePair", fileName = "EasePairEvent")]
    public sealed class EasePairEvent : AtomEvent<EasePair>
    {
    }
}
