using System;
using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Liver {
    public class CameraSizer : MonoBehaviour {
        public FloatReference Top;
        public FloatReference Left;
        public FloatReference Bottom;
        public FloatReference Right;

        void Start() {
            SizeVariables();
        }

        [Button]
        public void SizeVariables() {
            var c = Camera.main;
            var point1 = c.ScreenToWorldPoint(GetBottomLeft());
            var point2 = c.ScreenToWorldPoint(GetTopRight());
            Right.Value = point2.x;
            Top.Value = point2.y;
            Left.Value = point1.x;
            Bottom.Value = point1.y;
        }

        private Vector3 GetBottomLeft() {
            var c = Camera.main;
            if (c == null) {
                throw new Exception("Main camera is null!");
            }
            
            return new Vector3(-1f * c.pixelWidth, -1f * c.pixelHeight, 0f);
        }

        private Vector3 GetTopRight() {
            var c = Camera.main;
            if (c == null) {
                throw new Exception("Main camera is null!");
            }

            return new Vector3(c.pixelWidth / 2f, c.pixelHeight / 2f, 0f);
        }
    }
}