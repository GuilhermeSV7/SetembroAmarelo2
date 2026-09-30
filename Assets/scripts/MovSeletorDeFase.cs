using Unity.VisualScripting;
using UnityEngine;

public class MovSeletorDeFase : MonoBehaviour
{
	public float speed = 5f;

	private SpriteRenderer spriteRenderer;
	private Rigidbody2D rb;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");



		rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y).normalized * speed;
		rb.linearVelocity = new Vector2(rb.linearVelocity.x, moveVertical * speed).normalized * speed;

		rb.linearVelocity.Normalize();

		if (moveHorizontal < 0)
		{
			spriteRenderer.flipX = true;

		}
		else if (moveHorizontal > 0)
		{
			spriteRenderer.flipX = false;
		}
	}

	//	if (isFase1 == true)
	//	{
	//		fase1.SetActive(true);
	//	}
	//	else
	//	{
	//		fase1.SetActive(false);
	//	}
	//}

	//Fase code

	public GameObject fase1;
	public GameObject fase2;
	public GameObject fase3;

	public bool isFase1 = false;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Fase1"))
		{
			fase1.SetActive(true);
		}
		if (other.CompareTag("Fase2"))
		{
			fase2.SetActive(true);
		}
		if (other.CompareTag("Fase3"))
		{
			fase3.SetActive(true);
		}

	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Fase1"))
		{
			fase1.SetActive(false);
		}
		if (other.CompareTag("Fase2"))
		{
			fase2.SetActive(false);
		}
		if (other.CompareTag("Fase3"))
		{
			fase3.SetActive(false);
		}
	}
}
