using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
	public Transform playerCamera;
	public new Rigidbody rigidbody;
	public float accelleration;

	private void FixedUpdate()
	{
		Vector3 force = playerCamera.forward * Input.GetAxis("Vertical");
		force += playerCamera.right * Input.GetAxis("Horizontal");
		rigidbody.AddForce(force * accelleration);
	}
}
