using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cutTree : MonoBehaviour
{
    public Text logText;
    public int counter;
    public static int LogCount;
    public Text chopText;

    private void Update()
    {
    if(counter >= 20)
        {
            LogCount += 5;
            Debug.Log("Destroy tree now");
            counter = 0;
            Destroy(this.gameObject);
            logText.text = "Wood= " + LogCount;
            chopText.text = "";
            counter = 0;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered");
        if (Input.GetKeyDown("e") && other.tag == "Player")
        {
            counter++;
            Debug.Log(counter);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e") && other.tag == "Player")
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
