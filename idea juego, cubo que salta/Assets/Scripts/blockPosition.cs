using UnityEngine;
using System.Collections;

public class blockPosition : MonoBehaviour {


	public Transform[] block;
	public float offset;

	void Start () {
	
		block [1].position = new Vector3 (block [0].position.x, block [0].position.y, block [0].position.z + offset);
		block [2].position = new Vector3 (block [1].position.x, block [1].position.y, block [1].position.z + offset);
		block [3].position = new Vector3 (block [2].position.x, block [2].position.y, block [2].position.z + offset);
	}

	void Update () {
	
		
      }
}
