using UnityEngine;

namespace _Scriptable_Objects.Base
{
    [CreateAssetMenu(fileName = "New Int Value", menuName = "Scriptable Object/Base/Int VAlue")]
    public class IntValue : ScriptableObject
    {
        public float value;
    }
}