using System;
using _Scriptable_Objects.Base;
using UnityEngine.Serialization;

namespace _Scripts.Base_References
{
    [Serializable]
    public class IntReference : BaseReference
    {
        public float constantValue;
        public IntValue soValue;
        
        public float Value => UseConstant ? constantValue : soValue.value;
    }
}