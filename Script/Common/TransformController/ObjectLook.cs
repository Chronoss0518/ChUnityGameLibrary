using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLook : MonoBehaviour
{
    public GameObject targetObject = null;

    // Update is called once per frame
    void Update()
    {
        if (targetObject == null) return;

        transform.transform.LookAt(targetObject.transform.position);
    }
}
