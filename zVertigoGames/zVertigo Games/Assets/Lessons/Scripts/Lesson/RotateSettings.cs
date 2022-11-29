using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lessons
{
    [CreateAssetMenu(menuName = "Lessons/Lessons/Rotate Settings")]
    
    public class RotateSettings : ScriptableObject
    {
        [SerializeField] private float _speed;

        public float Speed { get { return _speed; } }
    }
}
