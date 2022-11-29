using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lessons
{
    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] private ControlRigidbodySettings _controlRigidbodySettings;
        private Rigidbody _rigidbody;

        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }


        void Update()
        {
            bool spaceKeyDown = Input.GetKeyDown(KeyCode.Space);
            if (spaceKeyDown)
            {
                _rigidbody.AddForce(_controlRigidbodySettings.JumpForce, ForceMode.Impulse);

            }

        }
    }

}