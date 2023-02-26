using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public int maxseconds;
    public static int seconds;
    public Scene victory;
    // Start is called before the first frame update
    void Start()
    {
        seconds = maxseconds + 1;
        InvokeRepeating("countDown", 0.0f, 1.0f);
    }

    void countDown()
    {
        seconds -= 1;
        GetComponent<TextMeshProUGUI>().text = (seconds/60).ToString()+":"+(seconds%60).ToString("d2");
        if (seconds < 5)
        {
            GetComponent<TextMeshProUGUI>().color = new Color(255, 0, 0);
        }
        if (seconds == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
