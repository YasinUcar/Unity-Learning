using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;
namespace TopDownShooter.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private InputData _inputData;
        [SerializeField] private PlayerMovementSettings _playermovementSettings;
        private void Update()
        {
            Movement();
        }
        private void Movement()
        {
            _rigidbody.MovePosition(_rigidbody.position + _rigidbody.transform.forward * _inputData.Vertical *
                _playermovementSettings.VerticalSpeed*Time.deltaTime);
            _rigidbody.MovePosition(_rigidbody.position + _rigidbody.transform.right * _inputData.Horizontal *
                _playermovementSettings.HorizontalSpeed*Time.deltaTime);

        }
    }
}