using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private RotateSettings _rotateSettings;
        private Rigidbody _rigidbody;
        void Start()
        {

        }

        void Update()
        {
            transform.Rotate(Vector3.up * _rotateSettings.Speed * Time.deltaTime);
        }
    }
}