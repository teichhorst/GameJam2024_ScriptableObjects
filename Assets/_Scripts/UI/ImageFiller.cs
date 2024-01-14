using System;
using _Scripts.Base_References;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace _Scripts.UI
{
    public class ImageFiller : MonoBehaviour
    {
        public FloatReference referenceValue;
        public FloatReference maxValue;

        public Image meterImage;

        private void Update()
        {
            meterImage.fillAmount = Mathf.Clamp01(referenceValue.Value / maxValue.Value);
        }
    }
}