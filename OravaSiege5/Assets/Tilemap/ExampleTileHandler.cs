using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ExampleTileHandler : MonoBehaviour
{
    // TESTING SCRIPT TO DEMO THE USE OF CHECKING TILES - MOVE THE CUBE AND PRESS SPACE TO CONFIRM THE TILE IT IS CURRENTLY ON :)
    // DO NOT CHANGE THE SCALE OF THE GRID -- CHANGE THE SCALE OF EVERYTHING ELSE AS IT WILL BREAK CHECKING LOCATIONS BETWEEN WORLD SCALE AND TILEMAP SCALE

    public Tilemap tilemap;

    // TILE TYPES
    public TileBase redTile;
    public TileBase blueTile;

    private void Update()
    {
        // JUST MOVEMENT FOR TILE TESTING
        if (Input.GetKeyDown(KeyCode.W)) transform.position += new Vector3(0, 0, 1);
        if (Input.GetKeyDown(KeyCode.S)) transform.position += new Vector3(0, 0, -1);
        if (Input.GetKeyDown(KeyCode.D)) transform.position += new Vector3(1, 0, 0);
        if (Input.GetKeyDown(KeyCode.A)) transform.position += new Vector3(-1, 0, 0);

        // TESTS FOR CURRENT TILE IN POSITION
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // CHECK TILE AGAINST TILE IN THE POSITION OF THIS OBJECT - USEFUL FOR CHECKING SINGLE TILE TYPES
            if (GlobalTileCheck.GetTileInPosition(transform.position, tilemap) == redTile) print("On Red Tile"); // CHECKS VARIABLE WITHOUT SAVING
            else
            {
                // GET THE TILE IN THE POSITION OF THIS OBJECT - THEN COMPARE TO TILES IN THIS SCRIPT - USEFUL FOR CHECKING AGAINST MULTIPLE TILE TYPES
                TileBase currentTile = GlobalTileCheck.GetTileInPosition(transform.position, tilemap); // SAVES TILE TO VARIABLE
                if (currentTile == blueTile) print("On Blue Tile"); // CHECKS VARIABLE
                else print("No Tile Here");
            }
        }
    }
}