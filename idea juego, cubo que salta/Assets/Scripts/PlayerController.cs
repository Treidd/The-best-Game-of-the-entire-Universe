using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private CharacterController playerController;
	private float velocity;
	private float gravity = 30f;
	public float speed;

	void Start () {
		playerController = GetComponent<CharacterController> ();
	}

	void Update () {
		
		if (playerController.isGrounded) {
			speed = 0;
			if (Input.GetMouseButtonDown (0)) {
				velocity = 10f;
			    speed = 5f;
			}
		} else {
			velocity -= gravity * Time.deltaTime;
		}
			
		Vector3 movementVector = new Vector3 (0, velocity, speed);
		playerController.Move (movementVector * Time.deltaTime);
	}

	private bool isPlayerGrounded()
	{
		Vector3 center;
		center = playerController.bounds.center;
		Debug.DrawRay (center, Vector3.down, Color.green);
		if (Physics.Raycast (center, Vector3.down,(playerController.height / 2) + 0.1f)){
			return true;
		}
		return false;
	}
}
