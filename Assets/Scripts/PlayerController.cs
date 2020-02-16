using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private GameObject _laserPrefab; 

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_laserPrefab, transform.position, Quaternion.identity);
        }
    }

    void CalculateMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontal * _speed * Time.deltaTime);
        transform.Translate(Vector3.up * vertical * _speed * Time.deltaTime);

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