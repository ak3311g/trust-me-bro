using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Find the player object by tag
        if (player == null)
        {
            Debug.LogError("Player not found! Make sure the player has the 'Player' tag.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            // Follow the player's position
            Vector3 newPosition = new Vector3(player.position.x, player.position.y, transform.position.z);
            transform.position = newPosition;
        }
        else
        {
            Debug.LogWarning("Player reference is null. Camera will not follow.");
        }
    }
}
