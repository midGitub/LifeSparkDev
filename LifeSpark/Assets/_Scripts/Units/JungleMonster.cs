﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class JungleMonster : UnitObject
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    gameObject.transform.Rotate(new Vector3(0,1,0));
	}
}