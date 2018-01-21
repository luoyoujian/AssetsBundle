using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class BuildController {

	public static void LaunchBuild(){
		//string path = Path.Combine(Application.dataPath, "L")
		var proc = new Process();
		proc.StartInfo.FileName = Application.dataPath + "/Lesson8.exe";
		proc.Start();
	}

}
