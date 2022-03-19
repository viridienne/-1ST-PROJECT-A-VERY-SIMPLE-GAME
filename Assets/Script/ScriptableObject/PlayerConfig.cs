using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PlayerConfig",menuName ="Player/Lives and Speed")]
public class PlayerConfig : ScriptableObject
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private int _lives;

    //properties
    public float Speed { get => _speed; set => _speed = value; }
    public int Lives { get => _lives; set => _lives = value; }
}
