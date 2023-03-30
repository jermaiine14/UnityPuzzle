using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcontroller : MonoBehaviour
{

    public GameObject thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetButton("Horizontal"))
        {
            thePlayer.GetComponent<Animator>().Play("Happy Walk");
        }

          if (Input.GetButton("Vertical"))
        {
            thePlayer.GetComponent<Animator>().Play("Happy Walk");
        }

           if (Input.GetButtonUp("Vertical"))
        {
            thePlayer.GetComponent<Animator>().Play("mixamo_com");
        }

           if (Input.GetButtonUp("Horizontal"))
        {
            thePlayer.GetComponent<Animator>().Play("mixamo_com");
        }
    }
}
