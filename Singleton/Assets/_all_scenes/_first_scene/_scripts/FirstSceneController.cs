﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FirstSceneController : MonoBehaviour {
	public Button button;

	
	void Start ()
    {
	    button.onClick.AddListener(delegate{
			GameController.Controller().GoToSecondScene();
		});
	}
	

}
