using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab; //Makes a public component where you can plug in the bullet Prefab materials.

    public float bulletForce; //Makes a public float that will affect the force of the bullet being ejected.

    public Transform bulletSpawnPosition; //Allows for the attachment of the spawn position of the bullet to be applied to the player.

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //If the player presses down on the left mouse button, it will do the following:
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);
            //It will spawn/instantiate a new bullet based on the position of the player.

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletForce);
            //Gets the rigidbody component of the bullet (the prefab), and adds force and direction to the bullet, allowing it to shoot
            //in a forward direction, from the position of the player.

            Destroy(bullet, 3f); //Will destroy the instantiated bullet after 3 seconds of firing.
        }
    }
}
