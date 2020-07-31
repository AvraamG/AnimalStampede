using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : Food
{
    private float movementSpeed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 direction = Vector3.forward * Time.deltaTime * movementSpeed;
        transform.Translate(direction);
    }
}
