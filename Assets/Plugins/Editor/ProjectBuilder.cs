using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

///
/// Testing out project building
///
public static class ProjectBuilder {
	private static readonly Dictionary<BuildTarget, string> locationPathNames = new Dictionary<BuildTarget, string> {
		{BuildTarget.StandaloneWindows,        "Builds/Windows/Tanks.exe"},
		{BuildTarget.StandaloneOSXUniversal,   "Builds/OSX/Tanks.app"},
		{BuildTarget.StandaloneLinuxUniversal, "Builds/Linux/Tanks.app"},
		{BuildTarget.WebGL,                    "Builds/WebGL"},
		{BuildTarget.iOS,                      "Builds/iOS"},
		{BuildTarget.Android,                  "Builds/Android"}
	};

	private static readonly Dictionary<BuildTarget, BuildOptions> buildOptions = new Dictionary<BuildTarget, BuildOptions> {
		{BuildTarget.StandaloneWindows,        BuildOptions.None},
		{BuildTarget.StandaloneOSXUniversal,   BuildOptions.None},
		{BuildTarget.StandaloneLinuxUniversal, BuildOptions.None},
		{BuildTarget.WebGL,                    BuildOptions.None},
		{BuildTarget.iOS,                      BuildOptions.None},
		{BuildTarget.Android,                  BuildOptions.None}
	};

	public static string Build (BuildTarget buildTarget)
	{
		var options = new BuildPlayerOptions();
		options.locationPathName = locationPathNames[buildTarget];
		options.options = buildOptions[buildTarget];
		options.scenes = EditorBuildSettingsScene.GetActiveSceneList(EditorBuildSettings.scenes);
		options.assetBundleManifestPath = AssetBundlesBuilder.AssetBundlesManifestPath;
		options.target = buildTarget;
		return BuildPipeline.BuildPlayer(options);
	}
	
	public static string BuildWithAssetBundles (BuildTarget buildTarget)
	{
		AssetBundlesBuilder.Build(buildTarget);
		return Build(buildTarget);
	}

	[MenuItem ("WGTestAssignment/Build project only")]
	public static string BuildActiveTarget ()
	{
		return Build(EditorUserBuildSettings.activeBuildTarget);
	}

	[MenuItem ("WGTestAssignment/Build project with asset bundles")]
	public static string BuildWithAssetBundlesActiveTarget ()
	{
		return BuildWithAssetBundles(EditorUserBuildSettings.activeBuildTarget);
	}
}