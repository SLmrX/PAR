using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextEntfernen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Entfernen()
    {
        transform.position = new Vector2(9999, 9999);
    }
}
