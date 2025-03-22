using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;

public class TargetRespawn : MonoBehaviour
{
    public List<Target> targets = new List<Target>(); //Compiles a list of the targets within the Target script. 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targets = FindObjectsByType<Target>(FindObjectsSortMode.InstanceID).ToList(); //Will find the targets based on type, and compile them to a list.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) //When the player inputs R on the keyboard, it will do the following:
        {
            foreach (Target t in targets) //Searches for every variable that is listed as target, it will do the following:
            {
               t.TargetRespawns(); //Run the void that is in the Target script, which respawns / reactivates the targets.
            }
        }
    }
}
