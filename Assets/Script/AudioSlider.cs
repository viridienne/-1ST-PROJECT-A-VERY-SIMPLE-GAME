using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSlider : MonoBehaviour
{
    [SerializeField]
    private Slider _audioSlider;

    [SerializeField]
    private AudioMixerGroup _audioMixer;
    [SerializeField]
    private string _paramsName;

    private float _volume;

    public float Volume 
    {
        get => _volume; 
        set 
        {
            _volume = value;
            _audioMixer.audioMixer.SetFloat(_paramsName, _volume);
            PlayerPrefs.SetFloat(_paramsName, _volume);
        }
    }

    public string ParamName
    {
        get => _paramsName;
        set => _paramsName = value;
    }
    // Start is called before the first frame update
    void Start()
    {
        _audioSlider.value = PlayerPrefs.GetFloat(_paramsName);
    }

    void Update()
    {
        Volume = _audioSlider.value;
    }
    
    public void SetUp(float value)
    {
        _audioMixer.audioMixer.SetFloat(_paramsName, value);
    }
    // Update is called once per frame
    //public void OnVolumeChanged()
    //{
    //    _volume = _audioSlider.value;
    //    _audioMixer.audioMixer.SetFloat(_paramsName, _volume);
    //}
}
