using UnityEngine;
using System.Collections;

public class ComplementController : MonoBehaviour
{
    private Prompt prompt;
    public GameObject startButton;
    public GameObject guiltCollider;
    // Use this for initialization

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == "Player" && Input.GetKeyDown(KeyCode.X))
        {
            prompt = GetComponentInChildren<Prompt>();
            if (prompt != null)
                StartCoroutine(prompt.PromptTrigger());
            else
            {
                // DO SOMETHING WHEN THE DIALGUE ENDS
            }
        }
    }
}
