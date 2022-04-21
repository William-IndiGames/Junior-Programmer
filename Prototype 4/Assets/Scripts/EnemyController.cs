/*
* Create by William (c)
* https://github.com/Long18
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

	#region Variables
	private Rigidbody enemyRb;
	private GameObject player;

	public float speed = 2.0f;
	#endregion

	#region Unity Mehods

	// Start is called before the first frame update
	void Start()
	{
		enemyRb = GetComponent<Rigidbody>();
		player = GameObject.Find("Player");
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 lookDirection = (player.transform.position - transform.position).normalized;
		enemyRb.AddForce(lookDirection * speed);

		if (transform.position.y < -10)
		{
			Destroy(gameObject);
		}
	}


	#endregion

	#region Class

	#endregion
}
