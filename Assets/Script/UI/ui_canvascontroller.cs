using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_canvascontroller : MonoBehaviour
{
    [SerializeField]
    private Text _txtSpeedInfo;
    [SerializeField]
    private Square _square;
    [SerializeField]
    private SpeedSetting config_data;
    [SerializeField]
    private Button _btnSpeedUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _txtSpeedInfo.text = $"Current Speed: {_square.Speed}\nConfig Speed: {config_data.Speed}";
    }
    public void OnBtnSpeedUpClicked()
    {
        _square.Speed += 1;
        config_data.Speed += 1;

    }
}
