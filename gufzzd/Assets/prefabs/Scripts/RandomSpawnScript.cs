using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnScript : MonoBehaviour
{
    public GameObject Green, Yellow, Black;

    public float spawnRate = 1f;

    float nextSpawn = 0f;

    int whatToSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 4);
            

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(Green, transform.position, Quaternion.identity);
                    
                    break;
                case 2:
                   Instantiate(Yellow, transform.position, Quaternion.identity);

                    break;
                case 3:
                   Instantiate(Black, transform.position, Quaternion.identity);
                    
                    break;
            }
            nextSpawn = Time.time + spawnRate;
        }

       
    }

}
