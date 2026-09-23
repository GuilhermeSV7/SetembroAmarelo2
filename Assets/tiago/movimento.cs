using UnityEngine;

public class movimento : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;
    public int move = 5;
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Movimento esquerda/direita 
        float speed = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        //Pulo 
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);


        }
    }
        private void OnCollisionEnter2D(Collision2D collision)
        {
          if (collision.gameObject.CompareTag("Isgrounded"))
          {
            isGrounded = true;
          }
       
        }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Isgrounded"))
        {
            isGrounded = false;
        }
    
    }


}

