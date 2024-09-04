using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RdAnomalies : MonoBehaviour
{
    public int Nm_anomalies;
    public GameObject AnomaliesManager;
    public GameObject barrie;
    public GameObject StreetEntrance;
    // Start is called before the first frame update
    void Start()
    {
        int level = PlayerPrefs.GetInt("Level", 0);
        if (level < 8)
        {
            Nm_anomalies = Random.Range(0, 13);
            Debug.Log("Anomalies: " + Nm_anomalies);
        }
        else if (level >= 8)
        {
            Nm_anomalies = 0;
            barrie.SetActive(false);
            StreetEntrance.SetActive(true);
            Debug.Log("Anomalies: " + Nm_anomalies);
        }


        AnomaliesManager anomaliesManager = AnomaliesManager.GetComponent<AnomaliesManager>();



        switch (Nm_anomalies)
        {
            case 0:
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 1:
                anomaliesManager.Anomalies1();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 2:
                anomaliesManager.Anomalies2();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 3:
                anomaliesManager.Anomalies3();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 4:
                anomaliesManager.Anomalies4();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 5:
                anomaliesManager.Anomalies5();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 6:
                anomaliesManager.Anomalies6();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 7:
                anomaliesManager.Anomalies7();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 8:
                anomaliesManager.Anomalies8();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 9:
                anomaliesManager.Anomalies9();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 10:
                anomaliesManager.Anomalies10();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 11:
                anomaliesManager.Anomalies11();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 12:
                anomaliesManager.Anomalies12();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
            case 13:
                anomaliesManager.Anomalies13();
                Debug.Log("Anomalies: " + Nm_anomalies);
                break;
        }
        
    }


   
}
