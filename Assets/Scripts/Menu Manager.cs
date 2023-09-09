using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Panel;
    public GameObject HowToPlayPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Panel.SetActive(false);
            HowToPlayPanel.SetActive(false);
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("Level 1 RBK");
    }

    public void SelectLevel()
    {
        Panel.SetActive(true);
    }

    public void HowToPlay()
    {
        HowToPlayPanel.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Level1Button()
    {
        SceneManager.LoadScene("Level 1 RBK");
    }

    public void Level2Button()
    {
        SceneManager.LoadScene("Level 2 RBK");
    }

}
