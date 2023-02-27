using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionChooser : MonoBehaviour
{
    public TextMesh text;
    public string[] questions;
    public string[] answer1;
    public string[] answer2;
    public string[] answer3;
    public string[] answer4;

    public TextMesh ans1text;
    public TextMesh ans2text;
    public TextMesh ans3text;
    public TextMesh ans4text;
    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, questions.Length);
        string question = questions[index];
        string[] split = question.Split(" ");
        for (int x = 0; x < split.Length; x++)
        {
            if (x % 6 == 0)
            {
                text.text += "\n";
            }
            text.text += split[x]+" ";
            
        }

        ans1text.text = answer1[index];
        ans2text.text = answer2[index];
        ans3text.text = answer3[index];
        ans4text.text = answer4[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
