using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private float speed = 20;
	private float turnSpeed = 50;

	private float horizontalInput;
	private float forwardInput;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//Player input
		horizontalInput = Input.GetAxis("Horizontal");
		forwardInput = Input.GetAxis("Vertical");

		//Move the vehicle forward
		/*transform.Translate(0,0,1);*/
		transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
		/*transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);*/
		transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
	}

}
