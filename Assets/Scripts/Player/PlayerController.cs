using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        ShootProjectile();
    }

    private void Move()
    {
     float movementSpeed=10;
    float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //TODO 
        //Those should be calculated by the CameraViewport.
        const float leftThreshold = -10;
        const float rightThreshold = 10;
        if (transform.position.x <leftThreshold)
        {
            transform.position = new  Vector3(leftThreshold,transform.position.y,transform.position.z);
        }else  if (transform.position.x >rightThreshold)
        {
            transform.position = new Vector3(rightThreshold, transform.position.y, transform.position.z);
        }
        this.transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * movementSpeed));
        this.transform.Translate(Vector3.forward * (verticalInput * Time.deltaTime * movementSpeed));

    }

    [SerializeField] private GameObject projectilePrefab;
    private void ShootProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, this.transform.position, this.transform.rotation);
        }
    }
}
