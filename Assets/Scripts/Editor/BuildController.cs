using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEditor;

public class BuildController {
	
	static public void LaunchBuild(BuildTarget platform) {
		// Get filename.
		var path = EditorUtility.SaveFolderPanel("Choose Location of Built Game", "", "");
		string[] levels = {"Assets/Scenes/MainScene.unity"};

		// Build player.
		BuildPipeline.BuildPlayer(levels, path + "/Lesson8.exe", platform, BuildOptions.None);


		var proc = new Process();
		proc.StartInfo.FileName = path + "/Lesson8.exe";
		proc.Start();
	}
}
