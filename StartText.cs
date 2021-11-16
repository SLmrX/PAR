using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartText : MonoBehaviour
{
    public GameObject startText;

    // Start is called before the first frame update
    public void Start()
    {
        startText.SetActive(false);
    }

    public void OnMouseOver()
    {
        startText.SetActive(true);
    }

    public void OnMouseExit()
    {
        startText.SetActive(false);
    }
}
