﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyHillPlace : MonoBehaviour {
	public GameObject human;
	
	public byte spawnChance;
	public byte humansMin;
	public byte humansMax;


	void Start () {
		foreach (Transform child in transform) 
			Destroy(child.gameObject);

		if (Random.Range(0, 100) <= spawnChance){
			for(byte i = 0, end = (byte)Random.Range(humansMin, humansMax); i < end; ++i){
				Instantiate(human, new Vector3(0, 0, 0) + this.transform.position, Quaternion.identity).transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			}
		}
	}
	
	void Update () {
		
	}
}