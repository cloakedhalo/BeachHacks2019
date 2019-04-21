using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gettingCut : MonoBehaviour
{
    public Text chopTtext;
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
