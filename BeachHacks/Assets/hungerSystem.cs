using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hungerSystem : MonoBehaviour
{
    float lastHungerUpdateTime = 0f;
    float currentTime;
    int hunger = 100;
    public Text textbox;

    

    private void Start()
    {
        textbox.text = "Hunger: " + 100;
    }
    void Update()
    {
        currentTime = Time.time;

        if (currentTime - lastHungerUpdateTime > 6f)
        {
            hunger -= 1;
            textbox.text = "Hunger: " + hunger;
            lastHungerUpdateTime = currentTime;
        }

        if (hunger < 1)
        {
            textbox.text = "Hunger: " + hunger;
            //die
        }
    }
}

