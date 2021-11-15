using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    Vector3 movement;
    [SerializeField] float speed;
    GameObject destroy;
    // Start is called before the first frame update
    void Start()
    {
        movement.y = speed;
        destroy = GameObject.Find("DestroyObj");
    }

    // Update is called once per frame
    void Update()
    {
        platformMove();
    }

    void platformMove()
    {
        transform.position += movement * Time.deltaTime;
        if (transform.position.y >= destroy.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
