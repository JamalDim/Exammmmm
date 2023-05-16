using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] float maxX;
    [SerializeField] float maxY;
    [SerializeField] float minX;
    [SerializeField] float minY;

    void Update()
    {
        Vector3 player_coord = new(Player.position.x, Player.position.y, this.transform.position.z);

        if (player_coord.x >= maxX)
        {
            player_coord.x = maxX - 1;
        }
        if (player_coord.x <= minX)
        {
            player_coord.x = minX + 1;
        }
        if (player_coord.y >= maxY)
        {
            player_coord.y = maxY - 1;
        }
        if (player_coord.y <= minY)
        {
            player_coord.y = minY + 1;
        }

        this.transform.position = player_coord;

    }
}
