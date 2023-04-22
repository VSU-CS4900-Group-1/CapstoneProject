using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public int damage = 1;
    public int currentHealth;
    public int maxHealth = 3;
    public float extraLives = 3;
    public float livesCounter;
    public Text LifeText;
    Renderer rend;
    Color c;
    private HealthManagerP HealthManagerP;
    public GameObject Player;
    public GameObject explosionPrefab;
   
    void Start()
    {
        HealthManagerP = GameObject.Find("HealthManagerP").GetComponent<HealthManagerP>();
        livesCounter = extraLives;
        
        rend = GetComponent<Renderer>();
        c = rend.material.color;
        currentHealth = maxHealth;
    }
    void Update() {
        HealthManagerP.UpdateHealth(currentHealth * 0.33333f);
        livesCounter = extraLives;
        LifeText.text = "x " + livesCounter;
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;        
    }

    
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {

            TakeDamage(damage);
            HealthManagerP.UpdateHealth(currentHealth * 0.33333f);
        }

        if (collision.gameObject.tag == "EnemyBullet") {
            Destroy(collision.gameObject);
            TakeDamage(damage);
            HealthManagerP.UpdateHealth(currentHealth *0.33333f);
        }

        if (currentHealth <= 0)
	      {
            StartCoroutine(Invulnerable());

            if (extraLives > 0) {
                
                extraLives -= 1;
                GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                explosion.GetComponent<ParticleSystem>().Play();
                Destroy(explosion, 2f);
                Player.transform.position = new Vector3(-500, -500, 0);
                
                StartCoroutine(Timer());
                StopCoroutine(Timer());
                


            }
            else {
                Player.transform.position = new Vector3(-500, -500, 0);
                GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                explosion.GetComponent<ParticleSystem>().Play();
                Destroy(explosion, 2f);
                //game over screen
            }
        }
    }

    IEnumerator Invulnerable() {
        Debug.Log("Invuln on");
        Physics2D.IgnoreLayerCollision(11, 9, true);
        Physics2D.IgnoreLayerCollision(11, 13, true);
        c.a = 0.5f;
        rend.material.color = c;
        yield return new WaitForSeconds(6f);
        Physics2D.IgnoreLayerCollision(11, 9, false);
        Physics2D.IgnoreLayerCollision(11, 13, false);
        c.a = 1f;
        rend.material.color = c;
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3);
        HealthManagerP.UpdateHealth(maxHealth * 100f);
        currentHealth = maxHealth;
        Player.transform.position = new Vector3(0, 0, 0);
       

            
	      }

    }


