using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            Rigidbody enemyRB = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            
            enemyRB.AddForce(awayFromPlayer * 500, ForceMode.Impulse);
        }

        if (collision.gameObject.CompareTag("Enemy2"))
        {
            Rigidbody enemyRB = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            enemyRB.AddForce(awayFromPlayer * 500, ForceMode.Impulse);
        }

        if (collision.gameObject.CompareTag("Enemy3"))
        {
            Rigidbody enemyRB = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            enemyRB.AddForce(awayFromPlayer * 500, ForceMode.Impulse);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody enemyRB = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            Handheld.Vibrate();
            enemyRB.AddForce(awayFromPlayer * 500, ForceMode.Impulse);
        }
    }

}
