using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewScript : MonoBehaviour
{
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(GetComponent<TextMesh>().color.a);
        if (transform.position == new Vector3(0, 0, 0))
        {
            active = true;
        }
        if (active)
        {
            GetComponent<TextMesh>().color = new Color(0, 0, 0, GetComponent<TextMesh>().color.a - 1.9f*Time.deltaTime);
        }
        if (GetComponent<TextMesh>().color.a <= 0.01f)
        {
            GetComponent<TextMesh>().color = new Color(0, 0, 0, 1);
            active = false;
            transform.position = new Vector3(123, 0, 0);
        }
    }
}
