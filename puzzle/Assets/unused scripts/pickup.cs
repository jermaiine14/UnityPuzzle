using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject whatPickup;
    public GameObject body;
    public Rigidbody pickupRigid;

    // Start is called before the first frame update
    void Start()
    {
        pickupRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
  

     

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pickupobj")){
            whatPickup = other.gameObject;
             whatPickup.transform.SetParent(body.transform);
            pickupRigid.constraints = RigidbodyConstraints.FreezePosition;
            Debug.Log("pakmijop!");
        }
    }
}
