using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintScript : MonoBehaviour
{
    public string hint;
    public GameObject question;
    public bool used;
    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 0.74f, 0.78f);
    }
    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 0.42f, 0.78f);
    }
    private void OnMouseDown()
    {
        if (!used)
        {
            question.GetComponent<TextMesh>().text = hint;
            GameManager.points -= 1;
            used = true;
        }
    }
}
