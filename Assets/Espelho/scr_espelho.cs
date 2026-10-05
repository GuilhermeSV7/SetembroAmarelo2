using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.UI.ScrollRect;

class scr_espelho: MonoBehaviour
{
	private float speed;

	private float jump;
	private float espelhotime;

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
	public GameObject PurpleGirl;
	public GameObject crystal1;
	public GameObject crystal2;
	public GameObject crystal3;
	public GameObject mirror0;
	public GameObject mirror1;
	public GameObject mirror2;
	public GameObject mirror3;
	public GameObject cutscene1;
	public GameObject cutscene2;
	public GameObject cutscene3;
	public GameObject cutscene4;
	public GameObject cutscene5;
    [SerializeField] private float MovementTime;
    [SerializeField] public float PlayerMovementSpeed = 3f;

    private void Start()
	{
		//StartCoroutine(startcutsceneespelho());
		rb = GetComponent<Rigidbody2D>();
		sprite = GetComponent<SpriteRenderer>();
		speed = 11;
		jump = 13;
		canJump = true;
		espelhotime = 0;
		scr_espelhostatic.podemover = true;
	}

	private void Update()
	{
		espelhotime += Time.deltaTime;
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

	IEnumerator startcutsceneespelho() 
	{
		scr_espelhostatic.podemover = false;
		rb.gravityScale = 0;
		//cutscene1.gameObject.SetActive(false);
		//cutscene2.gameObject.SetActive(false);
		//cutscene3.gameObject.SetActive(false);
		//cutscene4.gameObject.SetActive(false);
		//cutscene5.gameObject.SetActive(false);
		transform.position = new Vector3(-9, -5, 0);
		Debug.Log("a");
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.05f);
            transform.position = transform.position + new Vector3(0, 0.05f);
        }
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.05f);
            transform.position = transform.position + new Vector3(0, -0.05f);
        }
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.05f);
            transform.position = transform.position + new Vector3(0, 0.05f);
        }
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.05f);
            transform.position = transform.position + new Vector3(0, -0.05f);
        }
  //      cutscene1.gameObject.SetActive(true);
		//cutscene2.gameObject.SetActive(true);
		//cutscene3.gameObject.SetActive(true);
		//cutscene4.gameObject.SetActive(true);
		//cutscene5.gameObject.SetActive(true);
		rb.gravityScale = 3;
		scr_espelhostatic.podemover = true;
		yield return null;
	}
	IEnumerator espelhodie()
    {
    scr_espelhostatic.podemover = false;
    transform.position = new Vector3(10, -7.75f, 0);
	PurpleGirl.transform.position = new Vector3(0, 25, 0);
	PlayerDie.gameObject.SetActive(true);
    yield return new WaitForSeconds(1);
	PlayerDie.gameObject.SetActive(false);
	PlayerSpawn.gameObject.SetActive(true);
    yield return new WaitForSeconds(1);
    PlayerSpawn.gameObject.SetActive(false);
    scr_espelhostatic.podemover = true;
	scr_espelhostatic.espelholevel = 0;
    }

	IEnumerator espelhoend() 
	{
		statica.fase01time = espelhotime;
		statica.fase01completo = true;
		PlayerDie.gameObject.SetActive(true);
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene("SDF");
		yield return null;
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
        if (collision.gameObject.CompareTag("espelhocry"))
        {
            if (scr_espelhostatic.espelholevel == 1) { crystal1.gameObject.SetActive(false); scr_espelhostatic.crystal++; }
            if (scr_espelhostatic.espelholevel == 2) { crystal2.gameObject.SetActive(false); scr_espelhostatic.crystal++; }
            if (scr_espelhostatic.espelholevel == 3) { crystal3.gameObject.SetActive(false); scr_espelhostatic.crystal++; }
            if (scr_espelhostatic.crystal == 1) { mirror0.gameObject.SetActive(false); mirror1.gameObject.SetActive(true); }
			if (scr_espelhostatic.crystal == 2) { mirror1.gameObject.SetActive(false); mirror2.gameObject.SetActive(true); }
			if (scr_espelhostatic.crystal == 3) { mirror2.gameObject.SetActive(false); mirror3.gameObject.SetActive(true); }
        }
        if (collision.gameObject.CompareTag("espelhoend"))
        {
			StartCoroutine(espelhoend());
        }

    }
}