using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type AnimationCurve to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync AnimationCurve Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncAnimationCurveVariableInstancerToCollection : SyncVariableInstancerToCollection<AnimationCurve, AnimationCurveVariable, AnimationCurveVariableInstancer> { }
}
