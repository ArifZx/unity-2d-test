using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UtilButton : MonoBehaviour
{
  public void LoadScene(int value)
  {
    SceneManager.LoadScene(value);
  }
}
