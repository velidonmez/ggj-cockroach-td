using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeHealth : MonoBehaviour
{

    private int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HealthDecrease()
    {
        health--;
        if (health <= 0)
        {

        }
    }
}
