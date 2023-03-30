using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnappel : MonoBehaviour
{

    public GameObject appel;
    public Transform SpawnPoint;
    private int Getal;
    public AudioSource source;
    public AudioClip clip;
    

    void Start(){
        Getal = 1;
    }
    
    // Update is called once per frame
    public void SpawnAppel()
    { 
        if (Getal > 0){

        
            Instantiate(appel, SpawnPoint.position, Quaternion.identity);
            Getal--;
            source.PlayOneShot(clip);
        }
    }
}
