using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageShow : MonoBehaviour {
	public GameObject showMessage;
    ToastManager toastmanger;


	public void showToastMessage()
	{
		toastmanger.getToast ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
