using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveObstacle : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int damage = 20;

    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "Player")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            //DEAL DAMAGE
            target.gameObject.GetComponent<PlayerHealth>().ApplyDamage(damage);

            gameObject.SetActive(false);
        }
        if (target.gameObject.tag == "Bullet")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }

}
