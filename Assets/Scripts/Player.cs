using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");



        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
        transform.Translate(Vector3.up * vertical * speed * Time.deltaTime);

        // y < -4.1f y > 6 x >9.2 x < -4.1

        if (transform.position.y < -4.1f)
        {
            transform.position = new Vector3(transform.position.x, 6f, 0f);
        }
        else if (transform.position.y > 6f)
        {
            transform.position = new Vector3(transform.position.x, -4.1f, 0f);
        }
        else if (transform.position.x < -9.2f)
        {
            transform.position = new Vector3(9.2f, transform.position.y, 0f);
        }
        else if (transform.position.x > 9.2f)
        {
            transform.position = new Vector3(-9.2f, transform.position.y, 0f);
        }
    }
}