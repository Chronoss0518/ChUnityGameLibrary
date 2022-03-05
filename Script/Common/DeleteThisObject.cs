using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteThisObject : MonoBehaviour
{
    public GameObject targetObject = null;

    public void Delete()
    {
        Destroy(targetObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (targetObject != null) return;

        targetObject = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Start();
    }
}
