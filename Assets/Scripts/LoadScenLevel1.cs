using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScenLevel1 : MonoBehaviour
{
    public Button playButton;
    
    void Start()
    {
        playButton.onClick.AddListener(LoadNextScene);
    }

    
    void Update()
    {
        
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("Location1");

    }
}
