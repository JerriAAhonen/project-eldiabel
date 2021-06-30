using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform follow;

	private Vector3 offset;
	
	private void Start()
	{
		offset = transform.position - follow.position;
	}

	private void LateUpdate()
	{
		transform.position = Vector3.Lerp(transform.position, follow.position + offset, 0.1f);
	}
}
