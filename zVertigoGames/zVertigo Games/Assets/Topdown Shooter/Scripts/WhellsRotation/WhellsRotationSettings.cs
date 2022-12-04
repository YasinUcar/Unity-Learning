using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TopDownShooter/Player/Whells Rotation Settings")]
public class WhellsRotationSettings : ScriptableObject
{
    [SerializeField] private float _whellsRotationSpeed;
    public float RotationSpeed { get { return _whellsRotationSpeed; } }


}
    