using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEndScreen : MonoBehaviour
{
    Text ScoreEndscreen;
    // Start is called before the first frame update
    void Start()
    {
        ScoreEndscreen = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreEndscreen.text = "Score:" + score.scoreVar;
    }
}
