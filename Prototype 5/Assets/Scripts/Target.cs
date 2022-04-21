/*
* Create by William (c)
* https://github.com/Long18
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

	#region Variables

	private Rigidbody targetRb;

	private float minSpeed = 12;
	private float maxSpeed = 18;
	private float maxTorque = 100;
	private float xRange = 4;
	private float ySpawnPos = 2;
	#endregion

	#region Unity Mehods

	// Start is called before the first frame update
	void Start()
	{
		targetRb = GetComponent<Rigidbody>();

		targetRb.AddForce(RandomForce(), ForceMode.Impulse);
		targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

		transform.position = RandomSpawnPos();
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnMouseDown()
	{
		Destroy(gameObject);
	}

	private void OnTriggerEnter(Collider other)
	{
		Destroy(gameObject);
	}

	#endregion

	#region Class

	Vector3 RandomForce()
	{
		return Vector3.up * Random.Range(minSpeed, maxSpeed);

	}

	Vector3 RandomSpawnPos()
	{
		return new Vector3(Random.Range(-xRange, xRange), -ySpawnPos);
	}

	float RandomTorque()
	{
		return Random.Range(-maxTorque, maxTorque);

	}

	#endregion
}
