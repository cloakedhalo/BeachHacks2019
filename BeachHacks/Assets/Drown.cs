using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Drown : MonoBehaviour
{
    private void OnTriggerStart(Collider other)
    {
        Debug.Log("Object is in area");
        if (other.tag == "Player")
        {
            SceneLoader(2);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Object is in area");
        if (other.tag == "Player")
        {
            SceneLoader(2);
        }
    }
    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
