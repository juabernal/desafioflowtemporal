using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { Move(Vector3.forward);}

        if(Input.GetKey(KeyCode.S)) { Move(Vector3.back);}

        if(Input.GetKey(KeyCode.A)) { Move(Vector3.left); }

        if(Input.GetKey(KeyCode.D)) { Move(Vector3.right); }
    }

    private void Move(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

}
