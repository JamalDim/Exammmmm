using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour
{
    public Button goButton;

    void Start()
    {
        goButton.onClick.AddListener(LoadNextScene);
    }


    void Update()
    {

    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("Location2");

    }
}

