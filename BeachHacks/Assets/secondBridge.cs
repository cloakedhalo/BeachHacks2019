﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secondBridge : MonoBehaviour
{
    public static int logCount;
    public Text bridgeText;
// Start is called before the first frame update
void Start()
{
    gameObject.GetComponent<Renderer>().enabled = false;

}
private void Update()
{
    logCount = cutTree.LogCount;
}

// Update is called once per frame
void OnTriggerEnter(Collider other)
{
    Debug.Log("Object has entered");

}
private void OnTriggerStay(Collider other)
{
    Debug.Log("Object is in area");
    if (other.tag == "Player")
    {
        bridgeText.text = "Build bridge(F)(MUST HAVE 20 WOOD)";
        if (Input.GetKeyDown("f") && logCount >= 20)
        {
            bridgeText.text = "";
            gameObject.GetComponent<Renderer>().enabled = true;
            logCount = 0;
            bridgeText.text = "";
        }
    }
}
private void OnTriggerExit(Collider other)
{
    Debug.Log("Object has exited");
    bridgeText.text = "";

    }


}
