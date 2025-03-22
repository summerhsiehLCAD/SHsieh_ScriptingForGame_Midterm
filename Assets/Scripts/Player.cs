using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasGreenKey = false; //Something that will turn on/off the parts of the script that are linked to the Greenkey.

    public bool hasBlueKey = false; //Something that will turn on/off the parts of the script that are linked to the Bluekey.

    public bool hasRedKey = false; //Something that will turn on/off the parts of the script that are linked to the Redkey.

    public GameObject playerCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) //If the player presses down the E button, it will do the following:
        {
            RaycastHit hit; //This variable contains the data of what will be hit by the Raycast.

            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit)) //If the Raycast collider interacts with a specific object:
            {
                if (hit.collider.gameObject.tag == "Door") //And that object is tagged with the tag "door"
                {
                    LockedDoor door = hit.collider.gameObject.GetComponent<LockedDoor>(); //It will get the LockedDoor script and get the components from that script.
              
                        if ((door.keyColorRequired == KeyColor.Green && hasGreenKey) || //If the player presses E at the green door, and has the green key:

                            (door.keyColorRequired == KeyColor.Blue && hasBlueKey) || //If the player presses E at the blue door, and has the blue key:

                            (door.keyColorRequired == KeyColor.Red && hasRedKey)) //If the player presses E at the red door, and has the red key:
                        {
                            door.OpenDoor(); //Opens the door
                        }
                }
            }
        }
    }
}
