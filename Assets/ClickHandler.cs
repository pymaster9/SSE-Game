using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public GameObject affecting;
    public string function;
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
        print("Down");
        affecting.GetComponent<QuestionChooser>().Invoke(function, 0.0f);
    }
}
