using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    private PlayerController playerController;
    private Animator anim;
   
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        anim = GetComponent<Animator>();
    }

    void ResetShooting()
    {
        playerController.canShoot = true;
        anim.Play("Idle");
    }

    void CameraStartGame()
    {
        SceneManager.LoadScene("Level1");
    }

}
