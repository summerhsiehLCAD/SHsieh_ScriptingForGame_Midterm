using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasGreenKey = false;
    public bool hasBlueKey = false;
    public bool hasRedKey = false;

    public GameObject playerCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit; //This variable contains the data of what will be hit by the Raycast
            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit)) //
            {
                if (hit.collider.gameObject.tag == "Door")
                {
                    LockedDoor door = hit.collider.gameObject.GetComponent<LockedDoor>();
                    
                    if (door.isDoorLocked == true)
                    {
                        // Open Door

                        door.OpenDoor(); //Opens the door
                    }
                    else 
                    {
                        if ((door.keyColorRequired == KeyColor.Green && hasGreenKey) ||
                            (door.keyColorRequired == KeyColor.Blue && hasGreenKey) ||
                            (door.keyColorRequired == KeyColor.Red && hasRedKey))
                        {
                            //Open The Door

                            door.OpenDoor(); //Opens the door
                        }
                    }
                    
                }
            }
        }
    }
}
