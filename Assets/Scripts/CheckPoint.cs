using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    public GameObject GameObject;
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<TextUpdater>().textUpdate(GameObject.name);
            FindObjectOfType<SceneTransition>().ReloadScene();
        }
    }
}
