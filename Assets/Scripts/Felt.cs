using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Felt : MonoBehaviour
{
    public bool enemy1Dead, enemy2Dead, enemy3Dead, playerDead;

    public GameManager gameManager;
    int playerDown = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            gameManager.CountText(playerDown);
            enemy1Dead = true;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Enemy2"))
        {
            gameManager.CountText(playerDown);
            enemy2Dead = true;
            Destroy(collision.gameObject); 
        }
        else if (collision.gameObject.CompareTag("Enemy3"))
        {
            gameManager.CountText(playerDown);
            enemy3Dead = true;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.CountText(playerDown);
            playerDead = true;
            Destroy(collision.gameObject);
        }
    }
}
