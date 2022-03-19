using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float RotationtSpeed = 5f;
    public Transform bullet;
    private float direction = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0, verticalInput * movementSpeed * Time.deltaTime);
        direction += Input.GetAxis("Mouse X") * RotationtSpeed* Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, direction, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(bullet, transform.position + (transform.forward * 0.3f), transform.rotation);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
