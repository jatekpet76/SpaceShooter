using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -4.1f)
        {
            transform.position = new Vector3(Random.Range(-9.2f, 9.2f), 6f, 0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.LogFormat("Collide other: {0}", other.gameObject.name);

        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
