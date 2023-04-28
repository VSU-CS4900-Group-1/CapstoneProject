using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public PlayerHealth playerHealth;
   
    public float speed = 0f;
    public int damage = 1;
    public float BossHealth = 50f;
    public Sprite bossSprite;
    public GameObject explosionPrefab;
    private Scoring pointManager;
    private HealthManager HealthManager;
    private ParticleSystem.MainModule mainPS;
   
    // Start is called before the first frame update
    void Start()
    {
        HealthManager = GameObject.Find("HealthManager").GetComponent<HealthManager>();
        GetComponent<SpriteRenderer>().sprite = bossSprite;
    
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(0, 3), 1f * Time.deltaTime);
    }

    /* Calculates damage received and subtracts it from enemy health.
     * TODO: Currently only destroys enemy object when in contact with
     *      enemy*/
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            BossHealth -= 1f;
            HealthManager.UpdateHealth(BossHealth / 100f);
            if (BossHealth == 0) {
                
                Death();
            }
        }
    }

    /* Destroys enemy object and potentially spawns an item */
    void Death()
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        mainPS = explosion.GetComponent<ParticleSystem>().main;
        mainPS.startSize = new ParticleSystem.MinMaxCurve(7f, 12f);
        explosion.GetComponent<ParticleSystem>().Play();
        Destroy(explosion, 2f);
        Destroy(this.gameObject);
    }
}

