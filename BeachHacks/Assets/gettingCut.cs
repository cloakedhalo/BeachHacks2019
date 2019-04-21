using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gettingCut : MonoBehaviour
{
    int counter = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(Input.GetKeyDown("e"))
        {
            counter++;
            Debug.Log(counter);
        }
    }
}
