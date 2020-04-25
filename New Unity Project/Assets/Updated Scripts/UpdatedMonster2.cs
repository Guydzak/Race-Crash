using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatedMonster2 : MonoBehaviour
{
    public bool touch = false;
    public bool touch1 = false;
    public bool touch2 = false;

    public Transform player1;
    public Transform player2;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector3 movement;
    public float dp1, dp2, chaseSpeed, defSpeed;
    public int attackTime, boostTime;
    public AccelerationP1 p1;
    public AccelerationP2 p2;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        p1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<AccelerationP1>();
        p2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<AccelerationP2>();
    }

    // Update is called once per frame
    void Update()
    {
        dp1 = Vector2.Distance(transform.position, player1.position);
        dp2 = Vector2.Distance(transform.position, player2.position);
        if (dp2 > dp1)
        {
            Vector3 direction = player1.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            direction.Normalize();
            movement = direction;
        }
        else if(dp1 > dp2)
        {
            Vector3 direction = player2.position - transform.position + new Vector3(2,4,0);
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            direction.Normalize();
            movement = direction;
        }
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector3 direction)
    {
        rb.MovePosition((Vector3)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    
}
