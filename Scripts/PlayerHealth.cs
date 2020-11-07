using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerhealth : MonoBehaviour
{

    bool isDead;

    GameObject player;
    GameObject enemy;
    bool playerInRange;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == enemy)
        {
            playerInRange = true;

        }
    }

    public void TakeDamage (int amount)
    { 
       if(playerInRange && !isDead)
        {
            Death();
        }
    }

    void Death ()
    {
        isDead = true;
        gameObject.SetActive(false);
    }
}
