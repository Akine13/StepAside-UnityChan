using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDeleter : MonoBehaviour
{
	private GameObject unitychan;
	private float z;
	// Use this for initialization
	void Start()
	{
		z = transform.position.z;
		unitychan = GameObject.FindGameObjectWithTag("unitychanTag");
	}

	// Update is called once per frame
	void Update()
	{
		if (unitychan.transform.position.z >= z + 6)
		{
			Destroy(this.gameObject);
		}
	}
}