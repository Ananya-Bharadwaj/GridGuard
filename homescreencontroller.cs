using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homescreencontroller : MonoBehaviour
{
    // Reference to the Mode Selection Panel
    public GameObject modeselectionPanel;

    // This method is called when the Start button is clicked
    public void OnStartButtonClicked()
    {
        // Show the Mode Selection Panel
        modeselectionPanel.SetActive(true);
    }

    // Methods to load each game mode
    public void LoadMode1()
    {
        SceneManager.LoadScene("mode1scene");
    }

    public void LoadMode2()
    {
        SceneManager.LoadScene("mode2scene");
    }

    public void LoadMode3()
    {
        SceneManager.LoadScene("mode3scene");
    }

    public void LoadMode4()
    {
        SceneManager.LoadScene("mode4scene");
    }

}

