using System;
using _Scriptable_Objects.Base;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Scripts.Base_References
{
    [Serializable]
    public class ColorReference : BaseReference
    {
        public Color constantValue;
        public ColorValue soValue;
        
        public Color Value => UseConstant ? constantValue : soValue.value;
    }
}