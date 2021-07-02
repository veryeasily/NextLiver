using System;
using Shapes;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using TMPro;
using UnityEngine;

namespace Liver {
    public class Curtains : SerializedMonoBehaviour {
        public event Action OnFinishShowCurtains;
        public event Action OnFinishHideCurtains;

        [OdinSerialize] private Animator _animator;

        public void ShowCurtains() {
            _animator.speed = 1f;
            _animator.Play("Curtains_Show");
        }

        public void HideCurtains() {
            _animator.speed = 1f;
            _animator.Play("Curtains_Hide");
        }

        public void FinishShowCurtains() {
            Debug.Log("ANIMATION FINISHED");
            _animator.speed = 0f;
            OnFinishShowCurtains?.Invoke();
        }

        public void FinishHideCurtains() {
            Debug.Log("ANIMATION FINISHED");
            _animator.speed = 0f;
            OnFinishHideCurtains?.Invoke();
        }
    }
}