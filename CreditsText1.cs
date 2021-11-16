using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsText1 : MonoBehaviour
{
    public GameObject creditsText;

    // Start is called before the first frame update
    void Start()
    {
        creditsText.SetActive(false);
    }

    public void OnMouseOver()
    {
        creditsText.SetActive(true);
    }

    public void OnMouseExit()
    {
        creditsText.SetActive(false);
    }
}
