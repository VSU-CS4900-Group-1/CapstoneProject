using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour
{
    public GameObject Beam;
    public GameObject EnemyBullet;
    public Transform bulletPos;
    public int count;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (count == 4) {
            shootBeam();
            
            count -= 6;
            timer += 5;
        }
        if (timer > 1) {
            timer = 0;
            
            shoot();
            count++;
        }
        
    }

    void shoot() {
        Instantiate(EnemyBullet, bulletPos.position, Quaternion.identity);
    }
    void shootBeam() {
        Instantiate(Beam, bulletPos.position, Quaternion.identity);

    }
}
