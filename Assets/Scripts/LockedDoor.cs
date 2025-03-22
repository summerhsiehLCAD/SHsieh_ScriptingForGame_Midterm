using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public KeyColor keyColorRequired; //Matches the color of the key required with the color of the door. 

    public Transform doorFinalPosition; //Where the door final position should be inputed.

    public bool isDoorLocked = true; //If the door is locked, will run this function.

    public bool hasBeenOpened = false; //If the door has not been opened, will run this function.

    public AudioSource alreadyHasBeenOpened; //The audio clip that will play if the player tries to open the door again, even if it is already opened.


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
            //Whatever key color is required, will change the color of the door to correspond with it.
        }
        else if (keyColorRequired == KeyColor.Red) //If the key required is red, will run:
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            //Whatever key color is required, will change the color of the door to correspond with it.
        }
    }

    public void OpenDoor() //The function that will run once it has been called.
    {
        if (hasBeenOpened == false) //If the door has not been opened yet, and the player has the key it will:
        {
            this.transform.position = doorFinalPosition.position;
            //Move the door from it's starting position to it's final position.

            hasBeenOpened = true; //Afterwards sets that door hasBeenOpened to true, and disables it from moving again.
        }
        else if (hasBeenOpened == true) //if the door is opened, and the player attempts to press E again.
        {
            alreadyHasBeenOpened.Play(); //Will play this sound, indicating that the player can not move the door again.
        }
    }
}
