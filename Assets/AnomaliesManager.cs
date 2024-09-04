using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnomaliesManager : MonoBehaviour
{
    public GameObject Ano1;
    public GameObject Ano2;
    public GameObject Ano3;
    public GameObject Ano4;
    public GameObject Ano5;
    public GameObject Ano6;
    public GameObject Ano7;
    public GameObject Ano8;
    public GameObject Ano9;
    public GameObject Ano10;
    public GameObject Ano13;

    public GameObject Camera_ob;

    public GameObject FloorAno4;
    public Sprite SpriteAno10;
    public GameObject bin;
    public Material cam_off;


    public void Anomalies1()
    {
        Ano1.SetActive(true);
        bin.SetActive(false);
        Debug.Log("Anomalies1");
    }

    public void Anomalies2()
    {
        Ano2.SetActive(true);
        Debug.Log("Anomalies1");
    }

    public void Anomalies3()
    {
        Ano3.SetActive(true);
        Debug.Log("Anomalies1");
    }

    public void Anomalies4()
    {
        Ano4.SetActive(true);
        FloorAno4.SetActive(false);
        Debug.Log("Anomalies1");
    }

    public void Anomalies5()
    {
        Ano5.SetActive(true);
        Debug.Log("Anomalies1");
    }

    public void Anomalies6()
    {
        Ano6.SetActive(true);
        Debug.Log("Anomalies1");
    }

    public void Anomalies7()
    {
        Ano7Ontrigger ano7 = Ano7.GetComponent<Ano7Ontrigger>();
        ano7.enabled = true;
        Ano7.transform.Rotate(-90, 30, 0);
        Debug.Log("Anomalies1");
    }

    public void Anomalies8()
    {
        Ano8.SetActive(false);
        Debug.Log("Anomalies1");
    }

    public void Anomalies9()
    {
        Ano9.SetActive(true);
        Debug.Log("Anomalies1");
    }

    public void Anomalies10()
    {
        Ano10.GetComponent<SpriteRenderer>().sprite = SpriteAno10;
        Debug.Log("Anomalies1");
    }

    public void Anomalies11()
    {
        bin.SetActive(false);
        Debug.Log("Anomalies1");
    }

    public void Anomalies12()
    {
        Camera_ob.GetComponent<MeshRenderer>().materials[0] = cam_off;
        Debug.Log("Anomalies1");
    }

    public void Anomalies13()
    {
        Vector3 pos = Ano13.transform.position;
        pos.x = -12f;
        Debug.Log("Anomalies1");
    }
}
