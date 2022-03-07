using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public static PlayerMovement instance;

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool dash = false;

	public bool goingLeft = false;
	public bool goingRight = false;

	//bool dashAxis = false;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			if (instance != this)
			{
				Destroy(gameObject);
			}
		}

		DontDestroyOnLoad(gameObject);
	}

	void Update () {

		if (Input.GetKeyDown(KeyCode.Q))
		{
			horizontalMove = -1 * runSpeed;

			animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

			goingLeft = true;
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			horizontalMove = 1 * runSpeed;

			animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

			goingRight = true;
		}

		if (Input.GetKeyUp(KeyCode.Q)) { goingLeft = false; }
		if (Input.GetKeyUp(KeyCode.D)) { goingRight = false; }


		if (goingLeft == true)
		{
			horizontalMove = -1 * runSpeed;

			animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		}

		else if (goingRight == true)
		{
			horizontalMove = 1 * runSpeed;

			animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		}

		else if ( (goingLeft == false) & (goingRight == false) )
		{
			horizontalMove = 0 * runSpeed;

			animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		}


		if (Input.GetKeyDown(KeyCode.Space))
		{
			jump = true;
		}

		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			dash = true;
		}

		/*if (Input.GetAxisRaw("Dash") == 1 || Input.GetAxisRaw("Dash") == -1) //RT in Unity 2017 = -1, RT in Unity 2019 = 1
		{
			if (dashAxis == false)
			{
				dashAxis = true;
				dash = true;
			}
		}
		else
		{
			dashAxis = false;
		}
		*/

	}

	public void OnFall()
	{
		animator.SetBool("IsJumping", true);
	}

	public void OnLanding()
	{
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump, dash);
		jump = false;
		dash = false;
	}
}
