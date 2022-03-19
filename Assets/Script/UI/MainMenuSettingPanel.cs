using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenuSettingPanel : MonoBehaviour
{
    [SerializeField]
    private Slider _audioSlider;
    [SerializeField]
    private AudioMixerGroup _audioGroup;
    [SerializeField]
    private string _paramsName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnValueChanged()
    {
        _audioGroup.audioMixer.SetFloat(_paramsName, _audioSlider.value);
    }
}
