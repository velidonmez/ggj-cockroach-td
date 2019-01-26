using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerActions : MonoBehaviour
{
    public Sprite t_water;
    public Sprite t_lava;
    public Sprite t_brick;
    public Sprite t_ice;
    public Sprite t_grass;
    public Sprite t_stone;

    public GameObject cube;

    Tilemap tilemap;

    // Start is called before the first frame update
    void Start()
    {
        tilemap = FindObjectOfType<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float mouseX = Input.mousePosition.x;
            float mouseY = Input.mousePosition.y;
            Vector3 clickPoint = Camera.main.ScreenToWorldPoint(new Vector3(mouseX, mouseY, 10));

            Vector3Int cellPos = tilemap.WorldToCell(clickPoint);
            Sprite sprite = tilemap.GetSprite(cellPos);

            if (sprite.name == t_water.name)
            {

            }
            else if (sprite.name == t_lava.name)
            {

            }
            else if (sprite.name == t_brick.name)
            {

            }
            else if (sprite.name == t_ice.name)
            {

            }
            else if (sprite.name == t_grass.name)
            {

            }
            else if (sprite.name == t_stone.name)
            {

            }
        }
    }
}
