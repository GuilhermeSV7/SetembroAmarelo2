using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

class scr_espelho : MonoBehaviour
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
	public GameObject cutscene6;
	public GameObject cutscene7;
	public GameObject cutscene8;
	public GameObject cutscene9;
	public GameObject cutscene10;
	public GameObject cutscene11;
	public GameObject cutscene12;
	public GameObject cutscene13;
	public GameObject dialoguebox;
	public GameObject dialoguetext1;
	public GameObject dialoguetext2;
	public GameObject dialoguetext3;
	public GameObject dialoguetext4;
	public GameObject dialoguetext5;
	public GameObject dialoguetext6;
	public GameObject dialoguetext7;
	public GameObject dialoguetext8;
	public GameObject dialoguetext9;
	public GameObject dialoguetext10;
	public GameObject dialoguetext11;
	public GameObject dialoguetext12;
	public GameObject dialoguetext13;
	public GameObject dialoguetext14;
	public GameObject dialoguetext15;
    public GameObject dialoguetext16;
	public GameObject dialoguetext17;
	public GameObject dialoguetext18;
	public GameObject dialoguetext19;
	public GameObject dialoguetext20;
	public GameObject dialoguetext21;
	public GameObject dialoguetext22;
	public GameObject dialoguetext23;
	public GameObject dialoguetext24;
	public GameObject dialoguetext25;
	public GameObject dialoguetext26;
	public GameObject dialoguetext27;
	public GameObject dialoguetext28;
	public GameObject dialoguetext29;
	public GameObject dialoguetext30;
	public GameObject dialoguetext31;
	public GameObject dialoguetext32;
	public GameObject dialoguetext33;
	public GameObject dialoguetext34;
	public GameObject dialoguetext35;
	public GameObject dialoguetext36;
	public GameObject dialoguetext37;
	public GameObject dialoguetext38;
	public GameObject dialoguetext39;
	public GameObject dialoguetext40;
	public GameObject dialoguetext41;
	public GameObject dialoguetext42;
	public GameObject dialoguetext43;
	public GameObject dialoguetext44;
    [SerializeField] private float MovementTime;
    [SerializeField] public float PlayerMovementSpeed = 3f;

    private void Start()
	{
		StartCoroutine(startcutsceneespelho());
		rb = GetComponent<Rigidbody2D>();
		sprite = GetComponent<SpriteRenderer>();
		speed = 11;
		jump = 13;
		canJump = true;
		espelhotime = 0;
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

	IEnumerator startcutsceneespelho() 
	{
		scr_espelhostatic.podemover = false;
        transform.position = new Vector3(19, -16, 0);
        cutscene1.gameObject.SetActive(false);
		cutscene2.gameObject.SetActive(false);
		cutscene3.gameObject.SetActive(false);
		cutscene4.gameObject.SetActive(true);
		cutscene5.gameObject.SetActive(true);
		cutscene6.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        for (int i = 0; i < 70; i++)
        {
            yield return new WaitForSeconds(0.035f);
            cutscene4.transform.position = cutscene4.transform.position + new Vector3(0.1f, 0);
        }
        cutscene6.transform.position = cutscene4.transform.position;
        cutscene4.gameObject.SetActive(false);
        dialoguebox.gameObject.SetActive(true);
        dialoguetext1.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext1.gameObject.SetActive(false);
        dialoguetext2.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext2.gameObject.SetActive(false);
        dialoguetext3.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext3.gameObject.SetActive(false);
        dialoguetext4.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext4.gameObject.SetActive(false);
        dialoguetext5.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext5.gameObject.SetActive(false);
        dialoguetext6.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext6.gameObject.SetActive(false);
        dialoguetext7.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        for (int i = 0; i < 60; i++)
        {
            yield return new WaitForSeconds(0.005f);
            cutscene8.transform.position = cutscene8.transform.position + new Vector3(0.2f, 0);
        }
        cutscene7.gameObject.SetActive(true);
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.0125f);
            cutscene6.transform.position = cutscene6.transform.position + new Vector3(0, 0.075f);
        }
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.0125f);
            cutscene6.transform.position = cutscene6.transform.position + new Vector3(0, -0.075f);
        }
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.0125f);
            cutscene6.transform.position = cutscene6.transform.position + new Vector3(0, 0.075f);
        }
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.0125f);
            cutscene6.transform.position = cutscene6.transform.position + new Vector3(0, -0.075f);
        }
        for (int i = 0; i < 120; i++)
        {
            yield return new WaitForSeconds(0.0125f);
            cutscene6.transform.position = cutscene6.transform.position + new Vector3(0.3f, 0);
        }
        dialoguetext7.SetActive(false);
        cutscene1.gameObject.SetActive(true);
		cutscene2.gameObject.SetActive(true);
		cutscene3.gameObject.SetActive(true);
		cutscene4.gameObject.SetActive(false);
		cutscene5.gameObject.SetActive(false);
		cutscene6.gameObject.SetActive(false);
		cutscene7.gameObject.SetActive(false);
        transform.position = new Vector3(-17.5f, -7.5f, 0);
        yield return new WaitForSeconds(2);
        dialoguetext8.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext8.gameObject.SetActive(false);
        dialoguetext9.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext9.gameObject.SetActive(false);
        dialoguetext10.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext10.gameObject.SetActive(false);
        dialoguetext11.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext11.gameObject.SetActive(false);
        dialoguetext12.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext12.gameObject.SetActive(false);
        dialoguetext13.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext13.gameObject.SetActive(false);
        dialoguetext14.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext14.gameObject.SetActive(false);
        dialoguetext15.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext15.gameObject.SetActive(false);
        dialoguetext16.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext16.gameObject.SetActive(false);
        dialoguetext17.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext17.gameObject.SetActive(false);
        dialoguetext18.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext18.gameObject.SetActive(false);
        dialoguebox.SetActive(false);
        cutscene9.SetActive(false);
        cutscene10.SetActive(true);
        for (int i = 0; i < 120; i++)
        {
            yield return new WaitForSeconds(0.05f);
            cutscene10.transform.position = cutscene10.transform.position + new Vector3(-0.1f, 0);
        }
        scr_espelhostatic.podemover = true;
		yield return null;
	}
	IEnumerator espelhodie()
    {
    scr_espelhostatic.podemover = false;
	PlayerDie.gameObject.SetActive(true);
    yield return new WaitForSeconds(0.5f);
    transform.position = new Vector3(10, -7.75f, 0);
	PurpleGirl.transform.position = new Vector3(0, 25, 0);
    yield return new WaitForSeconds(0.5f);
	PlayerDie.gameObject.SetActive(false);
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
            if (scr_espelhostatic.crystal == 1) { mirror0.gameObject.SetActive(false); StartCoroutine(Dialogo1()); mirror1.gameObject.SetActive(true); }
			if (scr_espelhostatic.crystal == 2) { mirror1.gameObject.SetActive(false); StartCoroutine(Dialogo2()); mirror2.gameObject.SetActive(true); }
			if (scr_espelhostatic.crystal == 3) { mirror2.gameObject.SetActive(false); StartCoroutine(Dialogo3()); mirror3.gameObject.SetActive(true); }
        }
        if (collision.gameObject.CompareTag("espelhoend"))
        {
			StartCoroutine(espelhoend());
        }

    }
    IEnumerator Dialogo1()
    {
        transform.position = new Vector3(10, -7.75f, 0);
        PurpleGirl.transform.position = new Vector3(0, 25, 0);
        scr_espelhostatic.podemover = false;
        scr_espelhostatic.espelholevel = 0;
        dialoguebox.SetActive(true);
        dialoguetext19.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext19.gameObject.SetActive(false);
        dialoguetext20.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext20.gameObject.SetActive(false);
        dialoguetext21.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext21.gameObject.SetActive(false);
        dialoguebox.SetActive(false);
        scr_espelhostatic.podemover = true;
    }
    IEnumerator Dialogo2()
    {
        transform.position = new Vector3(10, -7.75f, 0);
        PurpleGirl.transform.position = new Vector3(0, 25, 0);
        scr_espelhostatic.podemover = false;
        scr_espelhostatic.espelholevel = 0;
        dialoguebox.SetActive(true);
        dialoguetext22.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext22.gameObject.SetActive(false);
        dialoguetext23.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext23.gameObject.SetActive(false);
        dialoguebox.SetActive(false);
        scr_espelhostatic.podemover = true;

    }
    IEnumerator Dialogo3()
    {
        transform.position = new Vector3(10, -7.75f, 0);
        PurpleGirl.transform.position = new Vector3(0, 25, 0);
        scr_espelhostatic.podemover = false;
        scr_espelhostatic.espelholevel = 0;
        dialoguebox.SetActive(true);
        dialoguetext24.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext24.gameObject.SetActive(false);
        dialoguetext25.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext25.gameObject.SetActive(false);
        transform.position = new Vector3(-17.5f, -7.5f, 0);
        cutscene11.SetActive(true);
        dialoguetext26.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext26.gameObject.SetActive(false);
        dialoguetext27.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext27.gameObject.SetActive(false);
        dialoguetext28.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext28.gameObject.SetActive(false);
        dialoguetext29.gameObject.SetActive(true);
        cutscene11.SetActive(false);
        cutscene12.SetActive(true);
        cutscene13.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext29.gameObject.SetActive(false);
        dialoguetext30.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext30.gameObject.SetActive(false);
        dialoguetext31.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext31.gameObject.SetActive(false);
        dialoguetext32.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext32.gameObject.SetActive(false);
        dialoguetext33.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext33.gameObject.SetActive(false);
        dialoguetext34.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext34.gameObject.SetActive(false);
        dialoguetext35.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext35.gameObject.SetActive(false);
        dialoguetext36.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext36.gameObject.SetActive(false);
        dialoguetext37.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext37.gameObject.SetActive(false);
        dialoguetext38.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext38.gameObject.SetActive(false);
        dialoguetext39.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext39.gameObject.SetActive(false);
        dialoguetext40.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext40.gameObject.SetActive(false);
        dialoguetext41.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext41.gameObject.SetActive(false);
        dialoguetext42.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext42.gameObject.SetActive(false);
        dialoguetext43.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext43.gameObject.SetActive(false);
        dialoguetext44.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        dialoguetext44.gameObject.SetActive(false);
        dialoguebox.SetActive(false);
        scr_espelhostatic.podemover = true;

    }
}