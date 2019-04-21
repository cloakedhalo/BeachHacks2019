using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutTree : MonoBehaviour
{
    public int counter;
    private void Update()
    {
    if(counter >= 20)
        {
            Debug.Log("Destroy tree now");
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered");
        if (Input.GetKeyDown("e"))
        {
            counter++;
            Debug.Log(counter);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
        {
            counter++;
            Debug.Log(counter);

        }
        Debug.Log("Object is in area");
      
    }
    void OnTriggerEnd(Collider other)
    {
        Debug.Log("Object left");
    }
}
