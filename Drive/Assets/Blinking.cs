using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Blinking : MonoBehaviour { 

    private int state = 2;
    public GameObject Blinker1;
    public GameObject Blinker2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(Blinker2.activeSelf)
            {
                Blinker2.SetActive(false);
            }
            Blinker1.SetActive(!Blinker1.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Blinker1.activeSelf)
            {
                Blinker1.SetActive(false);
            }
            Blinker2.SetActive(!Blinker2.activeSelf);
        }
    }
}
