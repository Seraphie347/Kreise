using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Countdown : MonoBehaviour
{


    public static float timeLeft = 30f;
    public Text text;
    public GameObject Green;
    public GameObject Yellow;
    public GameObject Black;
    void Awake()
    {
       
    }
    

    void Update()
    {
        timeLeft -= Time.deltaTime;                             //Zählt runter
        text.text = "Time Left:" + Mathf.Round(timeLeft);       //runded die Zahl 

        if (timeLeft <= 1)
        {
            SceneManager.LoadScene("GameEnd");
            
        }

    }
}
