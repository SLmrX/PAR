using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Map1");
    }
    public void Hauptmen�()
    {
        SceneManager.LoadScene("StartMen�");
    }
}
