using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Barrel;
    public float timeValue = 0;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(timeValue < 5)
        {
            timeValue += Time.deltaTime;
            
            
        }
        else if(timeValue == 5)
            {
                Instantiate(Barrel, transform.position, Quaternion.identity);
            }
    }

   
}
