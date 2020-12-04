using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        spawnTime = spawnTime - Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnTime <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawnTime = 3;
        }
    }
}
