using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    public TextMeshPro Text;
    public GameObject deDeur;
    private int Aantal;
    public int hoeveelnodig;
    private Vector3 startPosition;
    private Vector3 endPosition = new Vector3 (0,4,0);
    private float elapsedTime;
    public string needed;
    public AudioSource source;
    public AudioClip clip;
    private bool alreadyPlayed = false;
    public AudioClip clip2;
   
    
    // Start is called before the first frame update
    void Start()
    {
        Aantal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        
        if (Aantal == hoeveelnodig)
        {
            deDeur.transform.position -= Vector3.Lerp (startPosition,endPosition,Time.deltaTime);
            if (!alreadyPlayed)
            {
            source.PlayOneShot(clip2);
            alreadyPlayed = true;
          
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pickupobj"))
        {
            Destroy(other.gameObject);
            Debug.Log(Aantal);
            Aantal++;
            Text.text = Aantal.ToString() + "/" + needed;
            source.PlayOneShot(clip);
        }
    }    
    }

