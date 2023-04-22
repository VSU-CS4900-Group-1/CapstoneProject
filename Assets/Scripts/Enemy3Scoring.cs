using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Scoring : MonoBehaviour
{
    private Scoring pointManager;
    // Start is called before the first frame update
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<Scoring>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col) {

        if (col.gameObject.tag == "Bullet") {
            pointManager.UpdateScore(5000);
        }
    }
}
