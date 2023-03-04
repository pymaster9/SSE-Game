using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject correspondsTo;
    public GameObject music;
    private void OnMouseDown()
    {
        print("down");
        gameManager.GetComponent<GameManager>().Waypoint(correspondsTo);
        music.GetComponent<AudioSource>().Play();
    }
}
