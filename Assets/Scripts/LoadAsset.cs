using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.IO;
public class LoadAsset : MonoBehaviour {
    UnityWebRequest www;
    private void Start()
    {
  
    }
    /// <summary>
    /// Function Instantiate Asset from AssetBundle
    /// </summary>
    /// <param name="objeto">Name Object to instantiate</param>
    /// <param name="bundleName">Name Bundle</param>
    public void LoadLocal(string objeto, string bundleName)
    {
        var myLoadedAssetBundle = AssetBundle.LoadFromFile(
            Path.Combine(Application.streamingAssetsPath, "StandaloneWindows", bundleName));
        if (myLoadedAssetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }

        var prefab = myLoadedAssetBundle.LoadAsset<GameObject>(objeto);
        Instantiate(prefab);

        myLoadedAssetBundle.Unload(false);
    }

}
