using System;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Music : SerializedMonoBehaviour {
    public float WaitTime = 3f;

    private AudioSource _audio;
    
    public async void Start() {
        _audio = GetComponent<AudioSource>();
        await UniTask.Delay(TimeSpan.FromSeconds(WaitTime));
        _audio.Play();
    }
}