using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
    public Prompt pr;
	void Awake()
    {
        StartCoroutine(pr.PromptTrigger());
    }
}
