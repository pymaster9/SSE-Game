using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionChooser : MonoBehaviour
{
    public TextMesh text;
    public List<string> questions;
    public List<string> answer1;
    public List<string> answer2;
    public List<string> answer3;
    public List<string> answer4;
    public List<string> hints;
    public List<int> answers;
    public int answer;

    public TextMesh ans1text;
    public TextMesh ans2text;
    public TextMesh ans3text;
    public TextMesh ans4text;
    public HintScript hint;
    // Start is called before the first frame update
    public void Start()
    {
        try
        {
            int index = Random.Range(0, questions.Count);
            string question = questions[index];
            string[] split = question.Split(" ");
            text.text = "";
            for (int x = 0; x < split.Length; x++)
            {
                if (x % 6 == 0)
                {
                    text.text += "\n";
                }
                text.text += split[x] + " ";

            }

            ans1text.text = answer1[index];
            ans2text.text = answer2[index];
            ans3text.text = answer3[index];
            ans4text.text = answer4[index];
            answer = answers[index];
            hint.hint = hints[index];

            //remove the question
            questions.Remove(questions[index]);
            answer1.Remove(answer1[index]);
            answer2.Remove(answer2[index]);
            answer3.Remove(answer3[index]);
            answer4.Remove(answer4[index]);
            answers.Remove(answers[index]);
            hints.Remove(hints[index]);
        }
        catch
        {
            GameManager.points += 1;
        }

    }

    public void ChooseA()
    {
        if (answer == 0)
        {
            Start();
        }
    }

    public void ChooseB()
    {
        if (answer == 1)
        {
            Start();
        }
    }

    public void ChooseC()
    {
        if (answer == 2)
        {
            Start();
        }
    }

    public void ChooseD()
    {
        if (answer == 3)
        {
            Start();
        }
    }
}
