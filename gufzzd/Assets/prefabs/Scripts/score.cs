using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public static int scoreVar = 0;
    Text Score;

    void Start()
    {
        Score = GetComponent<Text>();

    }

    private void Update()
    {
        Score.text = "Score: " + scoreVar;
    }
}
