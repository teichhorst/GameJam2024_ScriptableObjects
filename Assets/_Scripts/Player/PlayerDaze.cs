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

        private void Awake()
        {
            playerSpeed.soValue.value = playerSpeedMax.Value;
        }

        public void DazePlayer()
        {
            Debug.Log("Dazed");
            playerSpeed.soValue.value = 0;
            StartCoroutine(Recover());
        }

        public IEnumerator Recover()
        {
            while (playerSpeed.Value < playerSpeedMax.Value)
            {
                yield return null;
                playerSpeed.soValue.value = Mathf.Clamp(playerSpeed.soValue.value + playerSpeedRecoveryRate.Value * Time.deltaTime, 0, playerSpeedMax.Value);
            }
        }
    }
}