using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelloader : MonoBehaviour
{

    public GameObject loadingscreen;
    public Slider slider;
  public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        loadingscreen.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress/.9f);
            slider.value = progress;    
            yield return null;

        }
    }


}
