using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreBoard : MonoBehaviour
{
    int Score;
    TMP_Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponent<TMP_Text>();
        scoretext.text = "start";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        Score += 1;
        scoretext.text = Score.ToString();
    }
}
