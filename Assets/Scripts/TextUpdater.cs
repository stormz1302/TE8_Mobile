using UnityEngine;
using TMPro;  

public class TextUpdater : MonoBehaviour
{
    public TextMeshPro textMeshPro; 
    private int level = 0;
    public GameObject RdAnomalies;
    private int _Nm_anomalies;
    public bool newGame = false;

    void Start()
    {
        RdAnomalies rdAnomalies = RdAnomalies.GetComponent<RdAnomalies>();
        _Nm_anomalies = rdAnomalies.Nm_anomalies;
        level = PlayerPrefs.GetInt("Level", 0);
    }

    private void Update()
    {
        if (newGame)
        {
            level = 0;
            PlayerPrefs.SetInt("Level", level);
            newGame = false;
        }
        textMeshPro.text = "EXIT " + level.ToString();
    }

    public void textUpdate(string namePoint)
    {
        if (_Nm_anomalies == 0)
        {
            if (namePoint == "Point1")
            {
                level = 0;
                PlayerPrefs.SetInt("Level", level);
            }
            else
            {
                level++;
                PlayerPrefs.SetInt("Level", level);
            }
        } 
        if (_Nm_anomalies != 0)
        {
            if (namePoint == "Point2")
            {
                level = 0;
                PlayerPrefs.SetInt("Level", level);
            }
            else
            {
                level++;
                PlayerPrefs.SetInt("Level", level);
            }
        }

    }

}
