using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour
{
    bool canAttackAgain = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(GameObject obj)
    {
        if (canAttackAgain == false) return;

        transform.eulerAngles += new Vector3(0, 0, 70);
        canAttackAgain = false;
        
        Destroy(obj);

        Invoke("Retake", 1.5f);
    }

    public void Retake()
    {
        transform.eulerAngles += new Vector3(0, 0, -70);
        Invoke("CanAttackAgain", 1.5f);
    }

    public void CanAttackAgain()
    {
        canAttackAgain = true;
    }
}
