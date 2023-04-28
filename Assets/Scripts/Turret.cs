using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour

{
    public float turnSpeed;         //The set turning speed of the turrets
    public Vector3 currPosition;    //The turret's current position
    public Vector3 playerPosition;  //The players current positions
    private GameObject player;        //Holds the player prefab as a Transform object

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        RotateTurret();
    }

    void RotateTurret()
    {
        //currPosition = transform.forward;
        playerPosition = player.transform.position - transform.position;
        float rotationAngle = Mathf.Atan2(playerPosition.y, playerPosition.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 0, rotationAngle - 90));
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, turnSpeed * Time.deltaTime);
        //transform.forward = Vector3.RotateTowards(currPosition, playerPosition, turnSpeed * Time.deltaTime, 180f);
    }
}
