using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuCanvasController : MonoBehaviour
{
    [SerializeField]
    private Button _buttonStart;
    [SerializeField]
    private Button _buttonQuit;
    [SerializeField]
    private TextMeshProUGUI _txtScore;

    [SerializeField]
    private TextMeshProUGUI _txtTime;

    [SerializeField]
    private Button _btnSetting;
    [SerializeField]
    private RectTransform _pnlSetting;
    // Start is called before the first frame update
    void Start()
    {
        _txtScore.text = $"Score: {PlayerPrefs.GetInt("score")}";
        _txtTime.text = $"Time: {PlayerPrefs.GetFloat("time")}";
    }

    // Update is called once per frame
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("SampleScene");
        
    }
    public void OnQuitButtongClicked()
    {
        Application.Quit();
    }
    public void OnBtnSettingClicked()
    {
        _pnlSetting.gameObject.SetActive(true);
    }
}
