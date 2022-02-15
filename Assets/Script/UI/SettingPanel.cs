using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SettingPanel : MonoBehaviour
{
    [SerializeField]
    private Button _btnexit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnExitButtonClicked()
    { 
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
