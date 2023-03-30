using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    private float dist;
    public Transform player;
    private bool Appel;
    private bool alreadyPlayed;
    public AudioSource source;
    public AudioClip clip;
    

    public float howclose;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);
        if (dist <= howclose)
        {
            Appel = true;
            
            if (Appel == true){ 
        enemy.SetDestination(player.position);

            if (!alreadyPlayed)
            {

                source.PlayOneShot(clip);
                alreadyPlayed = true;
            }
            }
        }

    }

    void OnCollisionStay (Collision other)
    {
        if (other.gameObject.CompareTag("pickupobj"))
        {
            Appel = false;
            enemy.speed = 0;
            Debug.Log("tja");
            
        }
    }

    void OnCollisionExit (Collision other)
    {
        if (other.gameObject.CompareTag("pickupobj"))
        {
            Appel = true;
            enemy.speed = 2;
            Debug.Log("yay");
            source.PlayOneShot(clip);
        }
    }


}

