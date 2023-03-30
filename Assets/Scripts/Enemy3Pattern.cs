using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Pattern : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed = 0f;
    //public Scoring pointManager;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        //pointManager = GameObject.Find("PointManager").GetComponent<Scoring>();
    }
    /*void OnCollisionEnter2D(Collision2D col) {

        if (col.gameObject.tag == "Bullet") {
           // pointManager.UpdateScore(5000);
            Destroy(collision.gameObject);
            Death();
        }
    }*/
    void Death() {
        GetComponent<ItemSpawning>().ItemInstance(transform.position);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update() {
        rb.velocity = new Vector2(0, -15f/*Random.Range(-10* Time.deltaTime, 8* Time.deltaTime)*/);
    }
}
