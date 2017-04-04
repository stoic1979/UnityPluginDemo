using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T {

	public int getToast() {

		// ANDROID
		if (Application.platform == RuntimePlatform.Android)
		{
			using (var javaUnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
			{
				using (var currentActivity = javaUnityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
				{
					using (var androidPlugin = new AndroidJavaObject("com.mylibrary.CustomToastUnity", currentActivity))
					{
						androidPlugin.Call("cutomeToast");

						return androidPlugin.Call<int>("getToast");

					}
				}
			}
		}

		// iOS
		if(Application.platform == RuntimePlatform.IPhonePlayer) {
			//throw new Exception ("James Bond Plugin Not ready for iOS");
			Debug.Log("James Bond Plugin Not ready for iOS");

			return -1;
		}

		// Desktop


		return -1;

	}

}
