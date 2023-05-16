using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int hp = 100;
    public int damage;
    
    
    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            hp -= 10;
        }
    }

    private void Damage()
    {

    } 
}
