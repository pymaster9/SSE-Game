using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    public int points;
    public GameObject goingto;
    private void OnMouseDown()
    {
        GameManager.points += points;
        GameManager.home.GetComponent<GameManager>().Waypoint(gameObject.transform.parent.gameObject, goingto);
    }
}
