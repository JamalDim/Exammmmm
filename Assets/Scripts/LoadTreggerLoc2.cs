using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadTreggerLoc2 : MonoBehaviour
{
    private Animator anim;
    public Vector3 position;
    public VectorValue playerStorage;


    private void Start()
    {
        anim = GetComponent<Animator>();

    }

    public void FadeToLevel()
    {
        anim.SetTrigger("fade");

    }

    public void OnFadeComplete()
    {
        playerStorage.initialValue = position;

    }

}  
