using System.Collections;
using UnityEngine;
using static UnityEngine.UI.ScrollRect;

class scr_espelho: MonoBehaviour
{
	private float speed;

	private float jump;

	private bool isGrounded;

	private Rigidbody2D rb;

	private SpriteRenderer sprite;
	private bool canJump;
    public Animator animator;
    public bool IsMovingUp;
    public bool IsMovingDown;
    public bool IsMovingLeft;
    public bool IsMovingRight;
    [SerializeField] private float MovementTime;
    [SerializeField] public float PlayerMovementSpeed = 3f;

    private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		sprite = GetComponent<SpriteRenderer>();
		speed = 11;
		jump = 13;
		canJump = true;
	}

	private void Update()
	{
		Walking();

		if (Input.GetKeyDown(KeyCode.Space) && canJump || Input.GetKeyDown(KeyCode.UpArrow) && canJump)
		{
			Jump();
		}
	}

	private void Walking()
	{
		float axisRaw = Input.GetAxisRaw("Horizontal");
		rb.linearVelocity = new Vector2(axisRaw * speed, rb.linearVelocity.y);
		//if (axisRaw > 0)
		//{
		//	sprite.flipX = false; // Olha para a direita
		//}
		//else if (axisRaw < 0)
		//{
		//	sprite.flipX = true;  // Olha para a esquerda
		//}
        if (MovementTime <= 0.01f)
        {
            IsMovingLeft = false;
            IsMovingRight = false;
            IsMovingUp = false;
            IsMovingDown = false;
            animator.SetBool("IsIdle", true);
            animator.SetBool("IsWalkingLeft", false);
            animator.SetBool("IsWalkingRight", false);
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            IsMovingRight = true;
            animator.SetBool("IsWalkingRight", true);
            animator.SetBool("IsWalkingLeft", false);
            animator.SetBool("IsIdle", false);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            IsMovingLeft = true;
            animator.SetBool("IsWalkingLeft", true);
            animator.SetBool("IsWalkingRight", false);
            animator.SetBool("IsIdle", false);
        }
    }

	private void Jump()
	{
			canJump = false;
			rb.linearVelocity = new Vector2(rb.linearVelocity.x, jump);
			StartCoroutine(JumpTimer());
	}

	public IEnumerator JumpTimer() 
	{
		yield return new WaitForSeconds(0.8f);
		canJump = true;
		yield return null;
	}
	//private void OnCollisionEnter2D(Collision2D collision)
	//{
	//	if (collision.collider.CompareTag("IsGrounded"))
	//	{
	//		isGrounded = true;
	//	}

	//	if (collision.collider.CompareTag("Inimigo"))
	//	{
	//		isGrounded = true;
	//	}
	//}

	//private void OnCollisionExit2D(Collision2D collision)
	//{
	//	if (collision.collider.CompareTag("IsGrounded"))
	//	{
	//		isGrounded = false;
	//	}
	//	if (collision.collider.CompareTag("Inimigo"))
	//	{
	//		isGrounded = false;
	//	}
	//}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("portalr1"))
		{
			transform.position = new Vector3(-23, 2);
			//Debug.Log("r1");
		}
		if (collision.gameObject.CompareTag("portalr2"))
		{
			transform.position = new Vector3(16.5f, -8);
            //Debug.Log("r2");
        }
		if (collision.gameObject.CompareTag("portalg1"))
		{
			transform.position = new Vector3(-3, 2);
            //Debug.Log("g1");
        }
		if (collision.gameObject.CompareTag("portalg2"))
		{
			transform.position = new Vector3(21.5f, -8);
            //Debug.Log("g2");
        }
		if (collision.gameObject.CompareTag("portalb1"))
		{
			transform.position = new Vector3(20, 2);
            //Debug.Log("b1");
        }
		if (collision.gameObject.CompareTag("portalb2"))
		{
			transform.position = new Vector3(26.5f, -8);
            //Debug.Log("b2");
        }
	}
}