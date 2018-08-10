using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Start(int Defence)
    {
        SceneManager.LoadScene("Defence");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
