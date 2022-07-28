using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public float lifeTime = 4f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }

}
