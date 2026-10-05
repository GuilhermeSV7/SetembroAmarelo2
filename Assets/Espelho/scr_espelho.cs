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
	public GameObject PlayerDie;
	public GameObject PlayerSpawn;
    [SerializeField] private float MovementTime;
    [SerializeField] public float PlayerMovementSpeed = 3f;

    private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		sprite = GetComponent<SpriteRenderer>();
		speed = 11;
		jump = 13;
		canJump = true;
		scr_espelhostatic.podemover = true;
	}

	private void Update()
	{
		if (scr_espelhostatic.podemover) { Walking(); }
		if (scr_espelhostatic.podemover) { 
		if (Input.GetKeyDown(KeyCode.Space) && canJump || Input.GetKeyDown(KeyCode.UpArrow) && canJump)
		{
			Jump();
		}
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
	//	if (collision.collider.CompareTag("espelhoenemy"))
	//	{
	//		StartCoroutine(espelhodie());
	//	}
	//}

	IEnumerator espelhodie()
    {
    scr_espelhostatic.podemover = false;
    transform.position = new Vector3(-26.5f, -7.75f, 0);
	PlayerDie.gameObject.SetActive(true);
    yield return new WaitForSeconds(2.5f);
	PlayerDie.gameObject.SetActive(false);
	PlayerSpawn.gameObject.SetActive(true);
    yield return new WaitForSeconds(2.5f);
    PlayerSpawn.gameObject.SetActive(false);
    scr_espelhostatic.podemover = true;
	scr_espelhostatic.espelholevel = 0;
    }


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
        if (collision.gameObject.CompareTag("espelhoenemy"))
        {
            StartCoroutine(espelhodie());
        }
        if (collision.gameObject.CompareTag("portalr1"))
		{
			transform.position = new Vector3(-23, 2);
			scr_espelhostatic.espelholevel = 1;
            //Debug.Log("r1");
        }
		if (collision.gameObject.CompareTag("portalr2"))
		{
			transform.position = new Vector3(16.5f, -8);
            scr_espelhostatic.espelholevel = 0;
            //Debug.Log("r2");
        }
		if (collision.gameObject.CompareTag("portalg1"))
		{
			transform.position = new Vector3(-3, 2);
            scr_espelhostatic.espelholevel = 2;
            //Debug.Log("g1");
        }
		if (collision.gameObject.CompareTag("portalg2"))
		{
			transform.position = new Vector3(21.5f, -8);
            scr_espelhostatic.espelholevel = 0;
            //Debug.Log("g2");
        }
		if (collision.gameObject.CompareTag("portalb1"))
		{
			transform.position = new Vector3(20, 2);
            scr_espelhostatic.espelholevel = 3;
            //Debug.Log("b1");
        }
		if (collision.gameObject.CompareTag("portalb2"))
		{
			transform.position = new Vector3(26.5f, -8);
            scr_espelhostatic.espelholevel = 0;
            //Debug.Log("b2");
        }
	}
}