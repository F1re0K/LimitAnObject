using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D body;
    private Transform myTransform;

    public Vector2 randomPoint;
    public Vector2 direction;

    private float speed;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        myTransform = GetComponent<Transform>();
    }

    private void Start()
    {
        GenerateRandomPoint();
        speed = Random.Range(2 , 5);
    }

    private void FixedUpdate()
    {
        body.AddForce(direction.normalized * speed);
    }

    private void Update()
    {
        direction = randomPoint - (Vector2)myTransform.position;
        CheckArrival();
    }

    private void GenerateRandomPoint()
    {
        randomPoint.Set(Random.Range(-1.72F, 1.72F), Random.Range(-4.15F, 4.15F));
    }

    private void CheckArrival()
    {
        if (Mathf.Abs(randomPoint.x - myTransform.position.x) < 0.5F && Mathf.Abs(randomPoint.y - myTransform.position.y) < 0.5F)
        {
            GenerateRandomPoint();
            speed = Random.Range(2 , 5);
        }
    }

    
}
