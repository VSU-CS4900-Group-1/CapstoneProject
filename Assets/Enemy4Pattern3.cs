using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4Pattern3 : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
