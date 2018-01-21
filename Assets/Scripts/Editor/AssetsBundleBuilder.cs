using UnityEditor;
using System.IO;
using UnityEngine;

public class AssetsBundleBuilder
{
	[MenuItem("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles()
	{
		BuildTarget platform = BuildTarget.StandaloneWindows;
		BuildAssetsBundle (platform);
		BuildController.LaunchBuild (platform);
	}

	static private void BuildAssetsBundle(BuildTarget platform){
		string path = Path.Combine(Application.streamingAssetsPath, "AssetBundles");
		if(!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}
		BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.None, platform);
	}

}