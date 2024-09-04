using UnityEngine;
using System.Collections.Generic;

public class ReloadSceneManager : MonoBehaviour
{

    public List<GameObject> persistentObjects = new List<GameObject>();

    void Start()
    {
        foreach (GameObject obj in persistentObjects)
        {
            if (obj != null)
            {
                DontDestroyOnLoad(obj);
            }
        }
    }
}
