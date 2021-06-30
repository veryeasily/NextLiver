using UnityEngine;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `EasePair`. Inherits from `AtomEventInstancer&lt;EasePair, EasePairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/EasePair Event Instancer")]
    public class EasePairEventInstancer : AtomEventInstancer<EasePair, EasePairEvent> { }
}
