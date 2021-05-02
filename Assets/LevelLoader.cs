using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Vuforia;

public class LevelLoader : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Slider slider;
    public Text ProgressText;
   public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsychronous(sceneIndex));
    }

    IEnumerator LoadAsychronous(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        LoadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            Debug.Log(progress);
            ProgressText.text = Mathf.RoundToInt(progress * 100f) + "%";
            yield return null;
        }
    }
    public void quit()
    {
        Application.Quit();
    }
}
