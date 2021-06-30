using UnityEngine;
using UnityAtoms.BaseAtoms;
using DG.Tweening;

namespace UnityAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Ease to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Ease Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncEaseVariableInstancerToCollection : SyncVariableInstancerToCollection<Ease, EaseVariable, EaseVariableInstancer> { }
}
