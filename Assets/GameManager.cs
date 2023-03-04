using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject map;
    public static int points;
    public static GameObject home;
    private void Awake()
    {
        home = gameObject;
    }
    public void Waypoint(GameObject swapto)
    {
        map.transform.position = new Vector3(200, 0, 0);
        swapto.transform.position = new Vector3(0, 0, 0);
    }
    public void BacktoMap(GameObject from)
    {
        Destroy(from);
        map.transform.position = new Vector3(0, 0, 0);
    }
}