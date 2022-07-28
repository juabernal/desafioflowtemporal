using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject munition;
    public float delaySpawn = 1f;
    public float repeatSpawn = 1f;

    // Start is called before the first frame update
    void Start()
    {
        munition.transform.localScale = new Vector3(0.4f, 0.3f, 1f);
        InvokeRepeating("Shoot", delaySpawn, repeatSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            munition.transform.localScale *= 2;
        }

    }

    private void Shoot()
    {
        Instantiate(munition, transform.position,transform.rotation);
    }
}
