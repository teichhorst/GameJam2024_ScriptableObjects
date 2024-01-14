using UnityEngine;

namespace _Scriptable_Objects.Base
{
    [CreateAssetMenu(fileName = "New Color Value", menuName = "Scriptable Object/Base/Color Value")]
    public class ColorValue : ScriptableObject
    {
        public Color value;
    }
}