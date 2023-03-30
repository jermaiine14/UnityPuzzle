using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    public AudioSource source;
    public AudioClip clip;
    public AudioClip clip2;
    public AudioClip clip3;

    bool isOpened = false;

   
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
              if(!isOpened){
        isOpened = true;
        door.transform.position -= new Vector3 (0,4,0);
        source.PlayOneShot(clip);
        source.PlayOneShot(clip2);
        }
        }
    }

      void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
             if (isOpened)
        {
            isOpened = false;
            door.transform.position += new Vector3(0, 4, 0);
            source.PlayOneShot(clip3);
        }
        }
    }

}
