using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shieldPrefab;    //Variable to hold the shield prefab
    private Animator anim;             //Variable for the prefab's animator controller

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(anim != null)
        {
            if (shieldPrefab.activeSelf)
            {
                anim.Play("DeflectorShieldsAnim");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Enemy")
        {
            Destroy(collider.gameObject);
        }

        if(collider.gameObject.tag == "EnemyBullet")
        {
            Destroy(collider.gameObject);
        }
    }
}
