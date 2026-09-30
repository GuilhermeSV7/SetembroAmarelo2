using UnityEngine;

public class scr_espelhomove1 : MonoBehaviour
{
	public float speed;

	public float jump;

	public bool isGrounded;

	public int vida;

	private Rigidbody2D rb;

	private SpriteRenderer sprite;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		sprite = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		Walking();
	}

	private void Walking()
	{
		float axisRaw = Input.GetAxisRaw("Horizontal");
		rb.linearVelocity = new Vector2(axisRaw * speed, rb.linearVelocity.y);
		if (axisRaw > 0)
		{
			sprite.flipX = false; // Olha para a direita
		}
		else if (axisRaw < 0)
		{
			sprite.flipX = true;  // Olha para a esquerda
		}
	}
}