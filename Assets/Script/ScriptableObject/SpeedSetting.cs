using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpeedSetting", menuName = "Tool/SpeedSetting")]
public class SpeedSetting : ScriptableObject
{
    [SerializeField]
    private float _speed;
    public float Speed { get => _speed; set => _speed = value; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
