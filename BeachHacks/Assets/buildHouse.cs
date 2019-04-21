using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buildHouse : MonoBehaviour
{
    public static int logCount;
    public Text houseText;
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
            houseText.text = "Build House(F)(MUST HAVE  WOOD)";
            if (Input.GetKeyDown("f") && logCount >= 30)
            {
                houseText.text = "";
                gameObject.GetComponent<Renderer>().enabled = true;
                logCount = 0;
                houseText.text = "";
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Object has exited");
        houseText.text = "";
    }

}
