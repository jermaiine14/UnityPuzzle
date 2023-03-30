using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
 {
     if (other.gameObject.tag == "player")
         SceneManager.LoadScene (0);
 }
}
