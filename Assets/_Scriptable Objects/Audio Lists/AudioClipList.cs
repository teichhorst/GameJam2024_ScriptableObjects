using System.Collections.Generic;
using UnityEngine;

namespace _Scriptable_Objects.Audio
{
    [CreateAssetMenu(fileName = "New Audio List", menuName = "Scriptable Object/Audio List")]
    public class AudioClipList : ScriptableObject
    {
        public List<AudioClip> clips;
        
        public Vector2 pitchRange = new Vector2(-0.6f, 1.4f);
    
        public AudioClip GetRandomClip()
        {
            return clips[Random.Range(0, clips.Count)];
        }

        public float GetRandomPitch()
        {
            return Random.Range(pitchRange.x, pitchRange.y);
        }
    }
}
