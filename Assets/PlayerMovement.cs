using System;
using UnityEngine;
using Util;

public interface IPlayerMovement
{
	Vector3 MovementDirection { get; }
}

public class PlayerMovement : SingletonBehaviour<IPlayerMovement>, IPlayerMovement
{
	public float movementSpeed;
	
	private CharacterController cc;

	public Vector3 MovementDirection { get; private set; } = Vector3.zero;

	protected override void Awake()
	{
		base.Awake();
		cc = GetComponent<CharacterController>();
	}

	private void Update()
	{
		var x = Input.GetAxis("Horizontal");
		var z = Input.GetAxis("Vertical");

		if (Math.Abs(x) > 0.01f || Math.Abs(z) > 0.01f)
		{
			var movement = new Vector3(x, 0, z);
			movement.Normalize();
			MovementDirection = movement;
			movement *= (movementSpeed * Time.deltaTime * 100);
			cc.SimpleMove(movement);
		}
	}
}
