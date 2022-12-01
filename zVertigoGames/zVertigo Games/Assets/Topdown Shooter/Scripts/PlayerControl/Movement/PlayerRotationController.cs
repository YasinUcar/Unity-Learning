using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;
public class PlayerRotationController : MonoBehaviour
{
    [SerializeField] private InputData _inputData;
    [SerializeField] private Transform _tower;

    void Update()
    {
        _tower.Rotate(0, _inputData.Horizontal, 0, Space.Self);
    }
}
