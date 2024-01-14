using System;
using _Scriptable_Objects.Base;
using UnityEngine.Serialization;

namespace _Scripts.Base_References
{
    [Serializable]
    public class FloatReference : BaseReference
    {
        public float constantValue;
        public FloatValue soValue;
        
        public float Value => UseConstant ? constantValue : soValue.value;
    }
}