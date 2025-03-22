using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyColor //Enum is a classification, and sets these new terms to be used within the script.
{
    Green,
    Blue,
    Red
}

public class Key : MonoBehaviour
{
    public KeyColor keyColor; //Allows for us to change the color of the keys in accordance to the terms listed in public enum.

    private void Start()
    {
        if(keyColor == KeyColor.Green) //Checks the enum and whether or not if the key is listed as green, and if it is green it will do the following:
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green; //Gets the color of the key, and sets the color to green.
        }
        else if (keyColor == KeyColor.Blue) //If the color is not listed as green, and instead blue, will do the following:
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue; //Gets the material of the key, and sets the color to blue.
        }
        else if (keyColor == KeyColor.Red) //If the color is not listed as green, and instead red, will do the following:
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red; //Gets the material of the key, and sets the color to red.
        }
    }

    void OnTriggerEnter(Collider other) //This function will run once the trigger has activated.
    {
        if (other.tag == "Player") //if the tag is labeled as Player, it will do the following:
        {
            Player player = other.gameObject.GetComponent<Player>(); //It will call the player script, and label "player" as other.

            if (keyColor == KeyColor.Green) //Checks the enum and whether or not if the key is listed as green, and if it is green it will do the following:
            {
                if (player.hasGreenKey == false) //If the player doesn't have a green key it will do the follwing:
                {
                    player.hasGreenKey = true; //The player will pick up the green key, and now have it in inventory.
                    Destroy(this.gameObject); //The gameObject key will be destroyed.
                }
            }
            else if (keyColor == KeyColor.Blue) //Checks the enum and whether or not if the key is listed as blue, and if it is blue it will do the following:
            {
                if (player.hasBlueKey == false) //If the player doesn't have a blue key it will do the follwing:
                {
                    player.hasBlueKey = true; //The player will pick up the blue key, and now have it in inventory.
                    Destroy(this.gameObject); //The gameObject key will be destroyed.
                }
            }
            else if (keyColor == KeyColor.Red) //Checks the enum and whether or not if the key is listed as red, and if it is red it will do the following:
            {
                if (player.hasRedKey == false) //If the player doesn't have a red key it will do the follwing:
                {
                    player.hasRedKey = true; //The player will pick up the red key, and now have it in inventory.
                    Destroy(this.gameObject); //The gameObject key will be destroyed.
                }
            }
            
        }
    }
}
