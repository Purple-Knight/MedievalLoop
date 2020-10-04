using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldMenu : MonoBehaviour
{
    public void WorldOne()
    {
        SceneManager.LoadScene(1);
    }

    public void WorldTwo()
    {
        SceneManager.LoadScene(2);
    }

    public void WorldTree()
    {
        SceneManager.LoadScene(3);
    }
}
