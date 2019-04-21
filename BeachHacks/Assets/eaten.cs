using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eaten : MonoBehaviour { 
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Coconut")
        {
            Destroy(collision.gameObject);

        }
    }
}
