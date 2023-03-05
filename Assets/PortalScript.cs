using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    public string code;
    public GameObject codeobj;
    public TextMeshProUGUI codetext;
    private void OnMouseDown()
    {
        codeobj.active = true;
    }
    public void CheckCode()
    {
        char zerospace = (char)8203;
        if (code == codetext.text.Trim(zerospace))
        {
            print("yee");
            GameManager.points += Timer.seconds / 30;
            SceneManager.LoadScene(1);
        }
    }
}
