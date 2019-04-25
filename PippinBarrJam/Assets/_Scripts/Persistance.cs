using UnityEngine;
using System.Collections;

public class Persistance : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(gameObject.transform.tag);
        if (objects.Length > 1)
            for (int i = 0; i < objects.Length; i++)
                if (objects[i].gameObject != this.gameObject)
                    Destroy(objects[i]);

        DontDestroyOnLoad(gameObject);
    }
}