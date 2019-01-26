using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float movementSpeed = 3;

    Waypoints waypoints;
    int target = 0;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = FindObjectOfType<Waypoints>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target >= 0)
        {
            Vector3 distance = waypoints.waypoints[target].transform.position - transform.position;
            Vector2 distance2D = new Vector2(distance.x, distance.y);
            Vector3 movement = distance2D.normalized * movementSpeed * Time.deltaTime;
            transform.position += movement;

            if (distance2D.sqrMagnitude < 2)
            {
                target++;
                if (target >= waypoints.waypoints.Length)
                    target = -1;
            }
        }
    }
}
