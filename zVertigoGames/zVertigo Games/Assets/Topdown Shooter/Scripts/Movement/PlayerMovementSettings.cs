using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TopDownShooter.PlayerMovement
{
    [CreateAssetMenu(menuName = "TopDownShooter/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        [Header("Movement")]
        [SerializeField] private float _verticalSpeed;
        [SerializeField] private float _horizontalSpeed;
        public float VerticalSpeed { get { return _verticalSpeed; } }
        public float HorizontalSpeed { get { return _horizontalSpeed; } }
        [Header("Jumping")]
        [SerializeField] private Vector3 _jumpForce;
        [SerializeField] private float  _jumpSpeed;
        public Vector3 JumpForce { get { return _jumpForce; } }
        public float JumpSpeed { get { return _jumpSpeed; } }
    }
}
