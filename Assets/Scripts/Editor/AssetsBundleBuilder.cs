using UnityEditor;
using System.IO;
using UnityEngine;

public class AssetsBundleBuilder
{
	[MenuItem("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles()
	{
		BuildAssetsBundle ();
		//BuildController.LaunchBuild ();
	}

	static private void BuildAssetsBundle(){
		string path = Path.Combine(Application.streamingAssetsPath, "AssetBundles");
		if(!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}
		BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
	}

}