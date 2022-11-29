using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TopDownShooter.PlayerMovement
{
    [CreateAssetMenu(menuName = "TopDownShooter/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        [SerializeField] private float _verticalSpeed;
        [SerializeField] private float _horizontalSpeed;
        public float VerticalSpeed { get { return _verticalSpeed; } }
        public float HorizontalSpeed { get { return _horizontalSpeed; } }
    }
}
