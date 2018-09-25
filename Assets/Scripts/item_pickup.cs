using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_pickup : MonoBehaviour
{

    public int playerHealth = 30;
    int damage = 10;

    void Start()
    {
        print(playerHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerHealth -= damage;
            print("We got hit" + playerHealth);
        }
    }
}

