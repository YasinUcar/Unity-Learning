using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    void Awake()
    {
        int numMusicPlayers = FindObjectsOfType<MusicPlayer>().Length; //"s"
        print(numMusicPlayers);
        if (numMusicPlayers > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
