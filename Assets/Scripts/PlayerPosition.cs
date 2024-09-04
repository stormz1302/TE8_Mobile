using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public Transform StartPoint;

    public Transform Player;
    public bool TeleFromPoint2 = false;

    

    public IEnumerator TeleportPlayer(Transform Point)
    {
       
        yield return new WaitForSeconds(0.1f);
        if (Point.name == "Point2" && TeleFromPoint2)
        {
            Debug.Log("Rotate"+ Point.name);
            Player.position = StartPoint.position;
        }
        else if (Point.name == "Point1" && !TeleFromPoint2)
        {
            Debug.Log("Rotate"+ Point.name);
            Player.position = StartPoint.position;
            Player.Rotate(0, 180, 0);
        }
        
    }
}
