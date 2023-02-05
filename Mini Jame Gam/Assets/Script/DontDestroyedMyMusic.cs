using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyedMyMusic : MonoBehaviour
{
    private void Awake()
    {
        int numberOfMusicPlayers = FindObjectsOfType<DontDestroyedMyMusic>().Length;
        if (numberOfMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}