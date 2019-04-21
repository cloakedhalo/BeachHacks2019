using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hungerSystem : MonoBehaviour
{
    float lastHungerUpdateTime = 0f;
    float currentTime;
    public static int hunger = 100;
    public Text textbox;
    public Text healthBar;
    public static int health = 100;
    private int cocoHunger = 10;

    

    public void Start()
    {
        textbox.text = "Hunger: " + hunger;
        healthBar.text = "HEALTH: " + health; 
    }
    void Update()
    {
        currentTime = Time.time;
        textbox.text = "Hunger: " + hunger;

        if (currentTime - lastHungerUpdateTime > 6f)
        {
            hunger -= 1;
            if(health <100)
            {
                health++;
                healthBar.text = "HEALTH: " + health;
            }
            textbox.text = "Hunger: " + hunger;
            lastHungerUpdateTime = currentTime;
        }

        if (hunger < 1)
        {
            textbox.text = "Hunger: " + hunger;
            health = 0;
            SceneLoader(2);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "food" && hunger < 100)
        {
            hunger += cocoHunger;
            if(hunger > 100)
            {
                hunger = 100;
            }
        }
    }
    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}

