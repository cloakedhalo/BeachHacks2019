using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickups : MonoBehaviour {
    public int woodCount=0;
    public Text chopText;
    public static int hunger;
    public void Start()
    {
        chopText.text = "Wood= " +woodCount;
    }
    public void Update()
    {
        hunger = hungerSystem.hunger;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "food" && hunger < 100)
        {
            Destroy(collision.gameObject);

        }
        if(collision.gameObject.name == "Log")
        {
            Destroy(collision.gameObject);
            woodCount++;
        }
    }
}
