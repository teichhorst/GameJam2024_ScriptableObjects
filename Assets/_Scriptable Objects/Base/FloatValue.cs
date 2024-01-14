using UnityEngine;

namespace _Scriptable_Objects.Base
{
    [CreateAssetMenu(fileName = "New Float Value", menuName = "Scriptable Object/Base/Float Value")]
    public class FloatValue : ScriptableObject
    {
        public float value;
    }
}
