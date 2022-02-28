using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void SceneChangeFromPath(string _loadScenePach)
    {
        SceneManager.LoadScene(_loadScenePach);
    }
    public void SceneChangeFromNo(int _loadSceneNo)
    {
        SceneManager.LoadScene(_loadSceneNo);
    }
}
