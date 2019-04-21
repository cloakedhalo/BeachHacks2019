using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickups : MonoBehaviour {
    public int woodCount=0;
    public Text chopText;
    public void Start()
    {
        chopText.text = "Wood= " +woodCount;
    }
    public void Update()
    {
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Coconut")
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
