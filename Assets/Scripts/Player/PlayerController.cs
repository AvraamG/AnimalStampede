using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed=10;
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
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        this.transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * movementSpeed));

        this.transform.Translate(Vector3.forward * (verticalInput * Time.deltaTime * movementSpeed));

    }
}
