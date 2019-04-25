using UnityEngine;
using System.Collections;

public class triggerDestroy : MonoBehaviour
{
    public GameObject [] destObjs;

    void OnTriggerEnter2D(Collider2D other)
    {
        for (int i = 0; i < destObjs.Length; i++)
            Destroy(destObjs[i]);
    }
}
