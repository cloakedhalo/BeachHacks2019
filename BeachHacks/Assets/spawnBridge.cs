using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBridge : MonoBehaviour
{
    public static int logCount;
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
        if(other.tag == "Player")
        {
            if (Input.GetKeyDown("f") && logCount >= 10)
            {
                gameObject.GetComponent<Renderer>().enabled = true;
                logCount = 0;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Object has exited");
    }


}
