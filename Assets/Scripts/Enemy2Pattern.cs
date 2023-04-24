using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Pattern : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed = 0.5f;
   // private Scoring pointManager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
        //pointManager = GameObject.Find("PointManager").GetComponent<Scoring>();
    }

    /*void OnCollisionEnter2D(Collision2D col) {

        if (col.gameObject.tag == "Bullet") {
            pointManager.UpdateScore(5000);
            Destroy(collision.gameObject);
            Death();
        }
    }*/
    void Death() {
        GetComponent<ItemSpawning>().ItemInstance(transform.position);
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;

        if (currentPoint == pointB.transform) {
            rb.velocity = new Vector2(-speed, -3f/*Random.Range(-10* Time.deltaTime, 8* Time.deltaTime)*/);
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
