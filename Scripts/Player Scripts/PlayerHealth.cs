using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int healthValue = 100;
    private Slider health_Slider;

    public GameObject UI_Holder;

    // Start is called before the first frame update
    void Start()
    {
        health_Slider = GameObject.Find("Health Bar").GetComponent<Slider>();
        health_Slider.value = healthValue;

        UI_Holder = GameObject.Find("UI Holder");
    }

    public void ApplyDamage(int damageAmount)
    {
        healthValue -= damageAmount;
        if (healthValue < 0)
        {
            healthValue = 0;
        }

        health_Slider.value = healthValue;

        if (healthValue == 0)
        {
            UI_Holder.SetActive(false);
            GamePlayController.instance.Gameover();
        }
    }
}
