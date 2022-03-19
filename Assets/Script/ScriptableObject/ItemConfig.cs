using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ItemConfig",menuName ="Item Data/Item Speed")]
public class ItemConfig : ScriptableObject
{
    [SerializeField]
    private float _speed;
    public float Speed { get => _speed; set => _speed = value; }
}
