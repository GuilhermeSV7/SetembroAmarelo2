using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovSeletorDeFase : MonoBehaviour
{
	public float speed = 5f;

	private SpriteRenderer spriteRenderer;
	private Vector3 moveDirection;
	private Rigidbody2D rb;
	private Animator playerAnimator;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		playerAnimator = GetComponent<Animator>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	private void FixedUpdate()
	{
		Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

		rb.linearVelocity = direction.normalized * speed;

		if (direction.x != 0)
		{
			ResetLayer();
            playerAnimator.SetLayerWeight(2, 1);

            if (direction.x < 0)
			{
				spriteRenderer.flipX = true;

			}
			else if (direction.x > 0)
			{
				spriteRenderer.flipX = false;
			}
		}

		if (direction.y > 0 && direction.x == 0)
		{
			ResetLayer();
			playerAnimator.SetLayerWeight(1, 1);
		}
        if (direction.y < 0 && direction.x == 0)
        {
            ResetLayer();
            playerAnimator.SetLayerWeight(0, 1);
        }

        if (rb.linearVelocity != Vector2.zero)
		{
			playerAnimator.SetBool("walking", true);
		}
		else
		{
			playerAnimator.SetBool("walking", false);
		}
	}

	private void ResetLayer()
	{
        playerAnimator.SetLayerWeight(0, 0); playerAnimator.SetLayerWeight(1, 0); playerAnimator.SetLayerWeight(2, 0);
    }

    private void Update()
	{
		//float moveX = Input.GetAxis("Horizontal");
		//float moveY = Input.GetAxis("Vertical");

		////moveDirection = new Vector3(moveVertical, moveHorizontal, 0f).normalized * speed;

		//rb.linearVelocity = new Vector2(moveX * speed, rb.linearVelocity.y).normalized * speed;
		//rb.linearVelocity = new Vector2(rb.linearVelocity.x, moveY * speed).normalized * speed;

		//rb.linearVelocity.Normalize();

		

		
	}

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
