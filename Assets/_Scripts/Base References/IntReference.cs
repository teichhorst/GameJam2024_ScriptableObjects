using _Scriptable_Objects.Base;

namespace _Scripts.Base_References
{
    public class IntReference
    {
        public bool UseConstant = true;
        public float ConstantValue;
        public IntValue Variable;
        
        public float Value
        {
            get { return UseConstant ? ConstantValue : Variable.value; }
        }
    }
}