using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class treeChopping : MonoBehaviour
{
    public int counter;
    public Text treeText;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Oak_Tree")
        {
            treeText.text = "PRESS E TO CHOP";
            if (Input.GetKeyDown("e"))
            {
                counter+=1;
                Debug.Log(counter);
            }
            if (counter == 5)
            {
                Destroy(collision.gameObject);
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Oak_Tree")
        {
            treeText.text = "";
        }
    }
}

