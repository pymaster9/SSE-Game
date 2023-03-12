using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    public int points;
    public GameObject goingto;
    public bool done;
    private void OnMouseDown()
    {
        if (!done)
        {
            GameManager.points += points;
            done = true;
        }
        GameManager.home.GetComponent<GameManager>().Waypoint(gameObject.transform.parent.gameObject, goingto);
    }
}
