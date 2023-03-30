using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;
    public AudioSource source;
    public AudioClip clip;
    

    private spawnappel AppelSpawnen;
    private ObjectGrabbable objectGrabbable;

    //als raycast object raakt met objectgrabbable script, dan pak op
  private void Update() {
    if (Input.GetKeyDown(KeyCode.E))    {
        if (objectGrabbable == null){
        float pickupDistance = 5f;
        if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickupDistance, pickUpLayerMask));{
            if (raycastHit.transform.TryGetComponent(out objectGrabbable)){
                objectGrabbable.Grab(objectGrabPointTransform);
                source.PlayOneShot(clip);
            }       
        }
    } else {
        objectGrabbable.Drop();
        objectGrabbable = null;

    //laat dan vallen
    }
  }
  //als speler q indrukt tegen een boom dan spawn een appel
   if (Input.GetKeyDown(KeyCode.Q))    {
        float pickupDistance = 5f;
        if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickupDistance, pickUpLayerMask));{
            if (raycastHit.transform.TryGetComponent(out AppelSpawnen)){
                AppelSpawnen.SpawnAppel();
            }       
        }
    } 
  }
}

