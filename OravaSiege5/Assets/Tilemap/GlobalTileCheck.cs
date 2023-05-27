using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public static class GlobalTileCheck
{
    // THIS IS A STATIC SCRIPT AND DOES NOT NEED TO BE ADDED TO A GAME OBJECT
    // FUNCTIONS CAN BE CALLED AT ANY TIME FROM ANY SCRIPT USING:: 'GlobalTileCheck.**Function**'

    // EXAMPLE FUNCTIONS OF CHECKING FOR TILES IN A POSITION ON THE MAP

    public static TileBase GetTileInPosition(Vector3 position, Tilemap tilemap) // GETS TILE IN CURRENT POSITION (RETURNS NULL IF NONE)
    {
        TileBase tile = tilemap.GetTile(ConvertToTileMapVector(position));
        return tile;
    }

    public static bool CheckForTileInPosition(TileBase tile, Vector3 position, Tilemap tilemap) // CHECKS FOR SPECIFIED TILE IN CURRENT POSITION (RETURNS BOOL)
    {
        return tile == tilemap.GetTile(ConvertToTileMapVector(position));
    }

    public static Vector3Int ConvertToTileMapVector(Vector3 position) // CONVERTS INTO 2D VECTOR WHILE ROUNDING TO AN INT (REQUIRED)
    {
        Vector3Int convertedPos = new Vector3Int((int)position.x, (int)position.z, 0);
        return convertedPos;
    }
}
