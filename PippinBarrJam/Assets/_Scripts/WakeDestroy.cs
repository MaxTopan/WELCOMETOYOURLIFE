using UnityEngine;
using System.Collections;

public class WakeDestroy : MonoBehaviour {

    public GameObject otherStart;
	void Awake()
    {
        Destroy(otherStart);
    }
}
