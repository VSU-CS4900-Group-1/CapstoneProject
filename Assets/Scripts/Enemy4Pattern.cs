using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4Pattern : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
    }

    // Update is called once per frame
    void Update() {
        Vector2 point = currentPoint.position - transform.position;

        if (currentPoint == pointB.transform) {
            rb.velocity = new Vector2(-speed, -15f/*Random.Range(-10* Time.deltaTime, 8* Time.deltaTime)*/);
        }

        else {
            rb.velocity = new Vector2(speed, 3f);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 2f && currentPoint == pointB.transform) {
            currentPoint = pointA.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 2f && currentPoint == pointA.transform) {
            currentPoint = pointB.transform;

        }
    }
}
