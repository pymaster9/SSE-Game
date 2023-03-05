using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public GameObject goingfrom;
    public GameObject gameManager;
    public GameObject correspondsTo;
    public bool startmusic;
    public GameObject music;
    public bool stopmusic;
    public GameObject musicstopped;
    private void OnMouseDown()
    {
        print("down");
        gameManager.GetComponent<GameManager>().Waypoint(goingfrom,correspondsTo);
        if (startmusic) { music.GetComponent<AudioSource>().Play(); }
        if (stopmusic) { musicstopped.GetComponent<AudioSource>().Pause(); }
    }
}
