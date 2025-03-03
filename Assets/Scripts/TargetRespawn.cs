using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;

public class TargetRespawn : MonoBehaviour
{
    public List<Target> targets = new List<Target>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targets = FindObjectsByType<Target>(FindObjectsSortMode.InstanceID).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            foreach (Target t in targets)
            {
               t.TargetRespawns();
            }
        }
    }


}
