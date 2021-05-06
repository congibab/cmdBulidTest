using UnityEditor;
using UnityEngine;
using UnityEditor.Build.Reporting;

public class BuildMGR : MonoBehaviour
{
    static void DoAutoBuild_Test()
    {
        string strResultDirectory = "C:/buildtest/result/test.exe";

        string[] vSceneList = { "./Assets/Scenes/SampleScene.unity" };
        BuildPipeline.BuildPlayer(
                vSceneList,
                strResultDirectory,
                BuildTarget.StandaloneWindows,
                BuildOptions.None);
    }

    static void DoAutoBuild_ios()
    {
        string strResultDirectory = "C:/buildtest/result/testios";

        string[] vSceneList = { "./Assets/Scenes/SampleScene.unity" };
        BuildPipeline.BuildPlayer(
                vSceneList,
                strResultDirectory,
                BuildTarget.iOS,
                BuildOptions.None);
    }
}
