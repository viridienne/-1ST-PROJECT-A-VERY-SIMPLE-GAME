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
    // Start is called before the first frame update
    void Start()
    {
        _txtScore.text = $"High Score: {PlayerPrefs.GetInt("score")}";
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
}
