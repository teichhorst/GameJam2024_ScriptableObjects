using System;
using _Scripts.Base_References;
using Unity.VisualScripting;
using UnityEngine;

namespace _Scripts.Player
{
    public class PlayerColor : MonoBehaviour
    {
        public FloatReference speed;
        public FloatReference maxSpeed;

        public Renderer playerRenderer;
        private Material _playerMaterial;

        public ColorReference playerColor;
        public ColorReference playerDazedColor;
        public ColorReference playerDefaultColor;
        private static readonly int Color1 = Shader.PropertyToID("_Color");

        private void Awake()
        {
            _playerMaterial = playerRenderer.material;
            playerColor.soValue.value = playerDefaultColor.Value;
        }

        private void Update()
        {
            playerColor.soValue.value = Color.Lerp(playerDazedColor.Value, playerDefaultColor.Value, speed.Value / maxSpeed.Value);
            _playerMaterial.SetColor(Color1, playerColor.Value);
        }
    }
}