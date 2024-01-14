using UnityEngine;

namespace _Scriptable_Objects.Base
{
    [CreateAssetMenu(fileName = "New Float Value", menuName = "Scriptable Object/Base/Float Value")]
    public class FloatVariable : ScriptableObject
    {
        public float value;
    }
}
