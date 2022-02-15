using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CanvasController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _txtScore;
    [SerializeField]
    private TextMeshProUGUI _txtLives;
    [SerializeField]
    private RectTransform _gameoverPanel;

    [SerializeField]
    private Button _buttonReplay;

    [SerializeField]
    private RectTransform _settingPanel;
    [SerializeField]
    private Button _buttonSetting;

    [SerializeField]
    private AudioSlider _masteraudioslider;
    [SerializeField]
    private AudioSlider _bgmaudioslider;
    [SerializeField]
    private AudioSlider _sfxaudioslider;

    // Start is called before the first frame update
    void Start()
    {
        _gameoverPanel.gameObject.SetActive(false);
        _masteraudioslider.SetUp(PlayerPrefs.GetFloat(_masteraudioslider.ParamName));
        _bgmaudioslider.SetUp(PlayerPrefs.GetFloat(_bgmaudioslider.ParamName));
        _sfxaudioslider.SetUp(PlayerPrefs.GetFloat(_sfxaudioslider.ParamName));

    }

    // Update is called once per frame
    public void SetLives(int lives)
    {
        _txtLives.text = $"Lives: {lives}";
    }
    public void SetScore(int score)
    {
        _txtScore.text = $"Score: {score}";
    }
    public void ShowGameOverUI()
    {
        _gameoverPanel.gameObject.SetActive(true);
    }
    public void OnReplayBttnClicked()
    {
        Debug.Log("OnReplayBttnClicked");
        Time.timeScale = 1f;

        SceneManager.LoadScene("SampleScene");

    }
    public void OnExitButtonClicked()
    {
        Debug.Log("Exit button clicked");
        SceneManager.LoadScene("MainMenu");
    }
    public void OnSettingButtonClicked()
    {
        Debug.Log("Setting button clicked");
        Time.timeScale = 0f;

        _settingPanel.gameObject.SetActive(true);
    }
}
