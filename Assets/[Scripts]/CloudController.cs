using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    public float verticleSpeed;
    public float horizontalSpeed;
    public Boundary boundary;
    public Boundary speeds;

    // Start is called before the first frame update
    void Start()
    {
        ResetObject();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        CheckBounds();
    }

    void Move()
    {
        transform.position -= new Vector3(horizontalSpeed, verticleSpeed);
    }

    void CheckBounds()
    {
        if (transform.position.y <= boundary.bottom)
        {
            ResetObject();
        }
    }

    void ResetObject()
    {
        float randomXposition = Random.Range(boundary.left, boundary.right);
        float randomYposition = Random.Range(boundary.top, boundary.top + 3.0f);
        verticleSpeed = Random.Range(speeds.bottom, speeds.top);
        horizontalSpeed = Random.Range(speeds.left, speeds.right);
        transform.position = new Vector2(randomXposition, randomYposition);
    }
}
