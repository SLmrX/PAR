using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitText : MonoBehaviour
{
    public GameObject exitText;

    // Start is called before the first frame update
    void Start()
    {
        exitText.SetActive(false);
    }

    public void OnMouseOver()
    {
        exitText.SetActive(true);
    }

    public void OnMouseExit()
    {
        exitText.SetActive(false);
    }
}
