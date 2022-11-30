using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.Shooting;
namespace TopDownShooter.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private Transform _cameraTransform;
        [SerializeField] private ShootingManager _shootingManager;
        private void Update()
        {
            CameraRotationFollow();
            CameraMovementFollow();
            if (Input.GetKeyDown(KeyCode.Space))
                _shootingManager.Shoot(_cameraTransform.transform.position, _cameraTransform.forward);
        }
        private void CameraRotationFollow()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation,
            Quaternion.LookRotation(_targetTransform.position - _cameraTransform.position), Time.deltaTime * _cameraSettings.RotationLerpSpeed);
        }
        private void CameraMovementFollow()
        {
            _cameraTransform.position = Vector3.Lerp(_cameraTransform.position, _targetTransform.position +
                _cameraSettings.PositionOffset, Time.deltaTime * _cameraSettings.PositionLerp);
        }
    }

}