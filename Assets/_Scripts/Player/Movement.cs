using System;
using _Scriptable_Objects.Base;
using _Scripts.Base_References;
using UnityEngine;

namespace _Scripts.Player
{
    public class Movement : MonoBehaviour
    {
        Rigidbody rb;

        public FloatReference speed;

        public FloatReference defaultSpeed;
        
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            speed.soValue.value = defaultSpeed.Value;
        }

        private void FixedUpdate()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            
            var movement = new Vector3(horizontal, 0.0f, vertical);
            rb.AddForce(movement * speed.Value);
        }
    }
}