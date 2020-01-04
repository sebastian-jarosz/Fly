﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pool {

	public int MaxCount;
	public Transform pooledObject;
	Stack<Transform> stos = new Stack<Transform>();
	
	
	
	// Use this for initialization
	public void Init () {
	  for (int i=0;i<MaxCount;i++) 
		{
			Transform obj = Object.Instantiate(pooledObject, Vector3.zero, Quaternion.identity) as Transform;
			stos.Push (obj);
		}
	}
	
	// Get
	public Transform getObject()
	{
		if (stos.Count >0) return stos.Pop();
		else return null;		
	}
	
	// Put
	public void putObject(Transform tr)
	{
		tr.position = Vector3.zero;
		tr.rotation = Quaternion.identity;
		stos.Push(tr);	
	}
	
}
