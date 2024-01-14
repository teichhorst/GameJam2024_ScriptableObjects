using System;
using _Scriptable_Objects.Audio;
using _Scripts.Base_References;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Scripts.Audio
{
    public class PlayAudioAtThreshold : MonoBehaviour
    {
        public AudioSource audioSource;
        
        public FloatReference threshold;
        
        public AudioClipList audioClipList;

        public FloatReference playerHealth;

        private bool _triggered;

        public void Update()
        {
            if (_triggered && playerHealth.Value < threshold.Value)
            {
                audioSource.pitch = Mathf.Lerp(audioClipList.pitchRange.x, audioClipList.pitchRange.y, playerHealth.Value / threshold.Value);
            }
            
            
            if (!_triggered && playerHealth.Value < threshold.Value)
            {
                _triggered = true;
                audioSource.clip = audioClipList.GetRandomClip();
                audioSource.Play();
                return;
            }
            
            if (_triggered && playerHealth.Value >= threshold.Value)
            {
                _triggered = false;
                audioSource.Stop();
            }

            if (_triggered && playerHealth.Value <= 0f)
            {
                audioSource.Stop();
            }
        }
    }
}