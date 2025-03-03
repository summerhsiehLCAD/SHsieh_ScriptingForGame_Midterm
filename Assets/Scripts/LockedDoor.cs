using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public KeyColor keyColorRequired; //Matches the color of the key required with the color of the door. 

    public Transform doorFinalPosition; //Where the door final position should be inputed

    public bool isDoorLocked = true; //If the door is locked, will run this function

    public bool hasBeenOpened = false; //If the door has not been opened, will run this function


    private void Start()
    {
        if (keyColorRequired == KeyColor.Green) //If the key required is green, will run:
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            //Whatever key color is required, will change the color of the door to correspond with it.
        }
        else if (keyColorRequired == KeyColor.Blue) //If the key required is blue, will run:
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            //Whatever key color is required, will change the color of the door to correspond with it
        }
        else if (keyColorRequired == KeyColor.Red) //If the key required is red, will run:
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            //Whatever key color is required, will change the color of the door to correspond with it
        }
    }

    public void OpenDoor() //The function that will run once it has been called.
    {
        if (hasBeenOpened == false) //If the door has not been opened yet, and the player has the key it will:
        {
            this.transform.position = doorFinalPosition.position;
            //Move the door from it's starting position to it's final position.
        }

        if (hasBeenOpened == true)
        {
            //play sound that indicates that player can't reopen the door.
        }
    }
}
