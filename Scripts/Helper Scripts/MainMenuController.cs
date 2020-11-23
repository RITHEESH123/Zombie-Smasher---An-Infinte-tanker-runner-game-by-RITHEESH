using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public Animator cameraAnim;

    public void GamePlay()
    {
        cameraAnim.Play("Slide");
    }
}
