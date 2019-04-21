using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class treeChopping : MonoBehaviour
{
    public Text treeText;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Oak_Tree")
        {
            treeText.text = "PRESS E TO CHOP";
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

