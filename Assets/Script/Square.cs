using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private SpeedSetting config_data;


    public float Speed { get => _speed; set => _speed = value; }
    // Start is called before the first frame update
    void Start()
    {
        _speed = config_data.Speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }
    }

}
