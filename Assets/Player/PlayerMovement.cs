using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeedMultiplier = 8;
    public float cameraFocusSpeedMultiplier = 6;
    public int cameraFocusMin = 35, cameraFocusMax = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float focus = Input.GetAxis("Focus");

        transform.Translate(new Vector2(horizontal, vertical) * movementSpeedMultiplier * Time.deltaTime);

        Camera.main.orthographicSize -= (focus * cameraFocusSpeedMultiplier * Time.deltaTime);
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, cameraFocusMax, cameraFocusMin);
    }
}
