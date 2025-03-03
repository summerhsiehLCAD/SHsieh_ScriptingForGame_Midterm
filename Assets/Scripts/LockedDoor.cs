using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public KeyColor keyColorRequired;

    public Transform doorFinalPosition;

    public bool isDoorLocked = true;

    public bool hasBeenOpened = false;


    private void Start()
    {
        if (keyColorRequired = KeyColor.Green)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else if (keyColorRequired == KeyColor.Blue)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if (keyColorRequired == KeyColor.Red)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    public void OpenDoor()
    {
        if(hasBeenOpened == false)
        {
            this.transform.position = doorFinalPosition.position;
        }
    }
}
