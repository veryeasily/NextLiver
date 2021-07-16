using System;
using UnityAtoms;
using UnityEngine;

namespace Liver.Atoms {
    [CreateAssetMenu(menuName = "Liver/Atoms/ThrowErrorAction")]
    public class ThrowErrorAction : AtomAction {
        public override void Do() {
            throw new Exception("Just threw intentional exception");
        }
    }
}