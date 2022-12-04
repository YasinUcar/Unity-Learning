using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;
public class WhellsRotationController : MonoBehaviour
{
    [SerializeField] private WhellsRotationSettings _whellsRotationSettings;
    [SerializeField] private InputData _inputData;
    [SerializeField] private Transform[] _whells; //0 = left whells 1 = right whells 2 = rear left whells 3 = rear right whells
    private void Update()
    {
        if (_inputData.Horizontal < 0)
        {
            _whells[0].Rotate(0, _inputData.Horizontal * _whellsRotationSettings.RotationSpeed, 0, Space.Self);
        }
        if (_inputData.Horizontal > 0)
        {
            _whells[1].Rotate(0, _inputData.Horizontal * _whellsRotationSettings.RotationSpeed, 0, Space.Self);
        }

    }
}
