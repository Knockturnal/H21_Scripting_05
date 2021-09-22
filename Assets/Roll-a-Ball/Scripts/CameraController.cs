using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform followTarget;

	private void LateUpdate()
	{
		transform.position = followTarget.position;
		transform.Rotate(Vector3.up, Input.GetAxis("Mouse X"));
	}
}
