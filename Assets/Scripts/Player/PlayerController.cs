using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float jumpSpeed;
    public bool isFacingright;
    
    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {    
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        flip();
        //pause and resume
        var movement = Input.GetAxis("Horizontal");

        transform.position += new Vector3(movement, 0, 0) * movementSpeed * Time.deltaTime;
       
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody2D.velocity.y) < 0.1f)
        {
            rigidbody2D.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }
      
    }
    public void flip()
    {
        var movement = Input.GetAxis("Horizontal");
        if ((movement > 0 && isFacingright) || (movement < 0 && !isFacingright))
        {
            isFacingright = !isFacingright;
            transform.Rotate(new Vector3(0, 180, 0));
        }
    }

}
