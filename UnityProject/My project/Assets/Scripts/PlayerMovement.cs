using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 5f;
    public Rigidbody2D ourbody;
    Vector2 movement;

    [SerializeField] private GameObject ourplayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


    }
    void FixedUpdate()
    {
        ourbody.MovePosition(ourbody.position + movement * movespeed * Time.fixedDeltaTime);
    }
}
