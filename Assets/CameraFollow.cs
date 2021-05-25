using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform follow;
	public Vector3 offset;

	private void LateUpdate()
	{
		transform.position = Vector3.Lerp(transform.position, follow.position + offset, 0.1f);
	}
}
