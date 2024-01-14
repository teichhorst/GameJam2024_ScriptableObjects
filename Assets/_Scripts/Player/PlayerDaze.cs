using System;
using System.Collections;
using _Scripts.Base_References;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.Player
{
    public class PlayerDaze : MonoBehaviour
    {
        public FloatReference playerSpeed;
        public FloatReference playerSpeedMax;
        public FloatReference playerSpeedRecoveryRate;

        private bool _isDazed;
        
        private void Awake()
        {
            playerSpeed.soValue.value = playerSpeedMax.Value;
        }

        public void DazePlayer()
        {
            playerSpeed.soValue.value = 0;
            
            if (_isDazed) return;
            
            StartCoroutine(Recover());
        }

        public IEnumerator Recover()
        {
            _isDazed = true;
            
            while (playerSpeed.Value < playerSpeedMax.Value)
            {
                yield return null;
                playerSpeed.soValue.value = Mathf.Clamp(playerSpeed.soValue.value + playerSpeedRecoveryRate.Value * Time.deltaTime, 0, playerSpeedMax.Value);
            }
            
            _isDazed = false;
        }
    }
}