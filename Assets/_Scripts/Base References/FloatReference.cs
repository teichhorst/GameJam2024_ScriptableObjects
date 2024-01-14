using System;
using _Scriptable_Objects.Base;

namespace _Scripts.Base_References
{
    [Serializable]
    public class FloatReference
    {
        public bool UseConstant = true;
        public float ConstantValue;
        public FloatVariable Variable;
        
        public float Value
        {
            get { return UseConstant ? ConstantValue : Variable.value; }
        }
    }
}