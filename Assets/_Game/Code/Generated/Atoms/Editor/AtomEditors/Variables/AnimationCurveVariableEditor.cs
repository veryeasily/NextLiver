using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `AnimationCurve`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(AnimationCurveVariable))]
    public sealed class AnimationCurveVariableEditor : AtomVariableEditor<AnimationCurve, AnimationCurvePair> { }
}
