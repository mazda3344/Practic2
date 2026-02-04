using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class ControlerPayerOficial : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2.0f;
        private Rigidbody playerRigidbody;
        private Vector3 movement;
        
        private void Awake ()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            float Vertical = Input.GetAxis(GlobalStringVars.VARTICAL_AXIS);
            movement = new Vector3(horizontal, 0, Vertical);
        }

        private void FixedUpdate()
        {
            MoveCharater();
        }

        private void MoveCharater()
        {
            playerRigidbody.AddForce(movement);
        }
#if UNITY_EDITOR
        [ContextMenu("Reset values")]
        public void ResetValues()
        {
            speed = 2;
        }
    }
#endif
}