using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Horse : MonoBehaviour
{
    [SerializeField] private GameObject spawn;
    private Transform player;
    private float speed = 25f;
    private float hunger = 200f;
    private float score = 1f;
    private bool isSpawn, isSpawned;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        // StartCoroutine(spawnDeer());
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
            StartCoroutine(spawnHorse());
    }

    private IEnumerator spawnHorse()
    {
        isSpawn = true;

        if (isSpawn && !isSpawned)
        {
            Quaternion forward = Quaternion.LookRotation(transform.forward);
            GameObject spawner = Instantiate (spawn, transform.position, forward);
            spawner.GetComponent<Rigidbody>().velocity = transform.forward * speed;
            isSpawned = true;
        }
        yield return new WaitForSeconds(1f);
        isSpawned = false;
        isSpawn = false;
    }

    private IEnumerator Interval()
    {
        yield return new WaitForSeconds (1f);
        isSpawned = false;
    }
}
