using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float allowedSpawnInterval = 1;
    //public float timeOfLastSpawnedDog = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        allowedSpawnInterval -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && allowedSpawnInterval <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            allowedSpawnInterval = 1;
        }
    }
}
