using UnityEngine;

public class scr_espelhomove2 : MonoBehaviour
{
	[SerializeField] private float speed = 5f;
	[SerializeField] private float jumpForce = 5;
	private Rigidbody2D rb;
	private bool IsGrounded;



	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		float move = Input.GetAxisRaw("Horizontal");

		rb.linearVelocity = new Vector2(speed * move, rb.linearVelocity.y);

		if (Input.GetButtonDown("Jump") && IsGrounded)
		{
			rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
		}

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.CompareTag("IsGrounded"))
		{
			IsGrounded = true;
		}

		if (collision.collider.CompareTag("Inimigo"))
		{
			IsGrounded = true;
		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.collider.CompareTag("IsGrounded"))
		{
			IsGrounded = false;
		}
		if (collision.collider.CompareTag("Inimigo"))
		{
			IsGrounded = false;
		}
	}
}