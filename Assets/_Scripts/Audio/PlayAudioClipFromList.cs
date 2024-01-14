using _Scriptable_Objects.Audio;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Scripts.Audio
{
    public class PlayAudioClipFromList : MonoBehaviour
    {
        public AudioClipList audioClipList;
        
        public AudioSource audioSource;

        public bool useRandomPitch;
        public bool canOnlyPlayOnce;
        
        private bool _hasPlayed;

        public void PlayClip()
        {
            if (canOnlyPlayOnce && _hasPlayed) return;
            
            Debug.LogFormat("Playing clip from {0}", audioClipList.name);
            
            audioSource.clip = audioClipList.GetRandomClip();
            
            if (useRandomPitch) audioSource.pitch = audioClipList.GetRandomPitch();
            
            audioSource.Play();
            
            _hasPlayed = true;
        }
    }
}