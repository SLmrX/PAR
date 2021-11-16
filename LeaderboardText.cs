using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardText : MonoBehaviour
{
    public GameObject leaderboardText;

    // Start is called before the first frame update
    public void Start()
    {
        leaderboardText.SetActive(false);
    }

    public void OnMouseOver()
    {
        leaderboardText.SetActive(true);
    }

    public void OnMouseExit()
    {
        leaderboardText.SetActive(false);
    }
}
