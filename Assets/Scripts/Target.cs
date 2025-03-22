using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetType //Another classification bracket, allows for us to use these terms within the script to manipulate.
{
    Destroyable,
    Movable,
    DestroyableWithSound
}

public class Target : MonoBehaviour
{ 
    public AudioSource targetSound; //Creates a public component allowing us to assign a sound clip.

    public TargetType targetType; //Creates a toggleable selection that allows the user to assign if the target object is
                                  //either Destroyable, Moveable, or DestroyablewithSound

    private Vector3 startingPosition; //Creates a Vector3 that is used to determine the movements for the Moveable target.

    public float maxMovingTargetRange = 3f; //This float will help constrain the movements of the Moveable target so that it stays within a certain range.

    void Start()
    {
        startingPosition = transform.position; //Defines the startingposition to the transform component on the target.

        if (targetType == TargetType.Destroyable) //Checks if the target type is Destroyable, and if it is will do the following:
        {
            this.GetComponent<MeshRenderer>().material.color = Color.magenta; //Assigns the target that is Destroyable the color magenta.
        }
        else if (targetType == TargetType.Movable) //Checks if the target type is Moveable, and if it is will do the following:
        {
            this.GetComponent<MeshRenderer>().material.color = Color.cyan; //Assigns the target that is Moveable the color cyan.
        }
        else if (targetType == TargetType.DestroyableWithSound) //Checks if the target type is DestroyableWithSound, and if it is will do the following:
        {
            this.GetComponent<MeshRenderer>().material.color = Color.yellow; //Assigns the target that is DestroyableWithSound the color yellow.
        }
    }

    void OnCollisionEnter(Collision other) //Creates a new code section that will happen on collision with the bullet.
    {
        if (other.gameObject.tag == "Bullet") //If the object that collides with these targets has the tag Bullet, it will do the following:
        {
            if(targetType == TargetType.Destroyable) //If the target type is Destroyable it will do the following:
            {
                gameObject.SetActive(false); //"Destroy" the target, or make the gameobject inactive.
            }
            else if(targetType == TargetType.Movable) //If the target type is Moveable it will do the following:
            {
                float randomY = Random.Range(-maxMovingTargetRange, maxMovingTargetRange); //Generates a random float, naming it randomY and bases it on the random range.
                float randomZ = Random.Range(-maxMovingTargetRange, maxMovingTargetRange); //Generates a random float, naming it randomZ and bases it on the random range.

                transform.position = startingPosition + new Vector3(0f, randomY, randomZ); //It will determine the new position of the target by taking the starting position
                                                                                           //adding it to a new Vector03 range based on the RandomY and RandomZ generated.
            }
            else if (targetType == TargetType.DestroyableWithSound) //If the target type is DestroyableWithSound it will do the following:
            {
                targetSound.Play(); //Will play the specific target sound.
                gameObject.SetActive(false); //Will set the gameobject to be inactive, invisible within the game view.
            }
        }
    }

    public void TargetRespawns() //Will play the following code:
    {
        this.gameObject.SetActive(true); //Sets the inactive gameobjects to active, effectively "respawning" them.
    }
}