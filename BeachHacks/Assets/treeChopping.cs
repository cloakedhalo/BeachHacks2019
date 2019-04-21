using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class treeChopping : MonoBehaviour
{
    public int counter;
    public Text treeText;
    public GameObject Log;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "tree")
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
                Instantiate(Log);
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

