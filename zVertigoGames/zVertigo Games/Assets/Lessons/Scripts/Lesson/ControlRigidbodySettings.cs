using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    [CreateAssetMenu(menuName = "Lessons/ControlRigidbody")]
    public class ControlRigidbodySettings : ScriptableObject
    {
        [SerializeField] private Vector3 _jumpForce;
        public Vector3 JumpForce { get { return _jumpForce; } }
    }

}