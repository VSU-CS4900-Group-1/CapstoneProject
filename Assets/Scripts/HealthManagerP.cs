using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManagerP : MonoBehaviour
{

    public Image HealthBarP;
    public float Health = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void UpdateHealth(float Health)
    {

        HealthBarP.fillAmount = Health;
    }
}