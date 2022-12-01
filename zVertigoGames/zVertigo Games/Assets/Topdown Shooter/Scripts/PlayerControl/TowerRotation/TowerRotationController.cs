using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;
namespace TopDownShooter.PlayControls
{
    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] private InputData _rotationInput;

        [SerializeField] Transform _towerTransform;
        [SerializeField] private TowerRotationSettings _towerRotationSettings;


        private void Update()
        {
            _towerTransform.Rotate(0, _rotationInput.Horizontal * _towerRotationSettings.TowerRotationSpeed, 0, Space.Self);
        }

    }

}