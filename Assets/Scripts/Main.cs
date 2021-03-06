﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LoadAssetsBundle ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void LoadAssetsBundle(){
		string path = Path.Combine(Application.streamingAssetsPath, "AssetBundles/win32");
		var bundle = AssetBundle.LoadFromFile (path);
		if (bundle != null) {
			var prefab = bundle.LoadAsset<GameObject> ("Sphere");
			for (int i = 0; i < 100; i++) {
				Instantiate (prefab, new Vector3 (Random.Range(-3, 3), 5 * i, 0), Quaternion.identity);
			}
		} else {
			Debug.Log ("Assets bundle cannot be loaded!");
		}
	}
}
