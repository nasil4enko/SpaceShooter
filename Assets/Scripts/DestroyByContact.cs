using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;

    public GameObject explosionPlayer;

    private GameObject cloneExplosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cloneExplosion = Instantiate(explosionPlayer, GetComponent<Rigidbody>().position, GetComponent<Rigidbody>().rotation) as GameObject;

            Destroy(other.gameObject);
            Destroy(gameObject);

            Destroy(cloneExplosion, 1f);
        }

        if (other.tag == "Bolt")
        {
            cloneExplosion = Instantiate(explosion, GetComponent<Rigidbody>().position, GetComponent<Rigidbody>().rotation) as GameObject;

            Destroy(other.gameObject);
            Destroy(gameObject);

            Destroy(cloneExplosion, 1f);
        }
    }
}
