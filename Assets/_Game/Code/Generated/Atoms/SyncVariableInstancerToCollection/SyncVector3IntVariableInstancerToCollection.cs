using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Vector3Int to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Vector3Int Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncVector3IntVariableInstancerToCollection : SyncVariableInstancerToCollection<Vector3Int, Vector3IntVariable, Vector3IntVariableInstancer> { }
}
