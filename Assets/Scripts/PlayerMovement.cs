using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This script allows for the player to move
    in a top-down view. It adds a Rigidbody2D 
    component to the player and takes in input
    horizontally and vertically to move the
    character.

    The script also allows for the player to
    rotate using the mouse. The player can
    aim the charm "weapon" using the mouse
    position as the "weapon" will shoot 
    automatically.
*/

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D player;

    public float movementSpeed = 10.0f;

    Vector2 movement;
    Vector2 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        player.MovePosition(player.position + movement * movementSpeed * Time.fixedDeltaTime);

        Vector2 lookDirection = mousePosition- player.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        player.rotation = angle;
    }
}
