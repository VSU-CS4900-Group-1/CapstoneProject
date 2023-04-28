using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {
    
    public Image HealthBarE;
    public float Health = 0;
    
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    public void UpdateHealth(float Health) {
        
        HealthBarE.fillAmount = Health;
    }
}
