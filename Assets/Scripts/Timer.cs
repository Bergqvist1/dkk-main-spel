using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{

    public float timer = 99;
    public TMP_Text tidText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        tidText.text = timer.ToString("Tid Kvar: 00");

        if(timer <= 0)
        {
            SceneManager.LoadScene(2);
        }


            
    }
}
