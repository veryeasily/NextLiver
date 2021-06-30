using UnityEngine;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Ease`. Inherits from `AtomEventInstancer&lt;Ease, EaseEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Ease Event Instancer")]
    public class EaseEventInstancer : AtomEventInstancer<Ease, EaseEvent> { }
}
