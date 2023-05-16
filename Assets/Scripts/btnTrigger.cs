using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnTrigger : MonoBehaviour
{

    public Animator anim;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            anim.SetTrigger("IsTriggered");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("IsTriggered");
        }
    }


}
