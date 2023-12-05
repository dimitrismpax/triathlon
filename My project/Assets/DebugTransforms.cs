using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTransforms : MonoBehaviour
{
	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Vector3 v = transform.position;
			UnityEngine.Debug.Log("x=" + v.x);
		}

		if (Input.GetButtonDown("Fire2"))
		{
			//  reset the object's position to (0,0,0)
			transform.position = new Vector3(0, 0, 0);
		}

	}
}
