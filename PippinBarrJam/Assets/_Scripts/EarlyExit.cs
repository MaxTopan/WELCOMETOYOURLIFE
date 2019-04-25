using UnityEngine;
using System.Collections;

public class EarlyExit : MonoBehaviour
{
    public GameObject obj;
    void OnDestroy()
    {
        obj.SetActive(true);
    }
}
