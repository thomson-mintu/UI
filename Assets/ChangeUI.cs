using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeUI : MonoBehaviour
{
    public Scene scene;
    public int index;
   public void openScene()
    {
        SceneManager.LoadScene(index);
       
    }
}
