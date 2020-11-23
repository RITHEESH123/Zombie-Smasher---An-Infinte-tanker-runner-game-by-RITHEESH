using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody myBody;

    public void Move(float speed)
    {
        myBody.AddForce(transform.forward.normalized * speed);
        Invoke("DeactivateGameObject", 5f);
    }

    void DeactivateGameObject()
    {
        gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "Obstacle")
        {
            gameObject.SetActive(false);
        }
    }
}
