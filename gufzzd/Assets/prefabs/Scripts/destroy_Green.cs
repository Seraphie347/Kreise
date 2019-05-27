using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_Green : MonoBehaviour
{

    public  GameObject timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 3.0f);
    }
       
    void OnMouseDown()
    {
        Countdown.timeLeft += 2;
        Destroy(this.gameObject);
    }
}

