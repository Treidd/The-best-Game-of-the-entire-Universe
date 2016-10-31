using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform player;
	public float smooth;
	public Vector3 desiredPosition;
	public Vector3 offset;

	void LateUpdate () {
	
     	desiredPosition = player.transform.position + offset;
		transform.position = Vector3.Lerp (transform.position,desiredPosition,smooth * Time.deltaTime);

	}
}
