using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour
{
    public int level = 0;

    void Awake()
    {
        Application.LoadLevel(level);
    }
}
