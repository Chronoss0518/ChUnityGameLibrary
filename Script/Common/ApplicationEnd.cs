using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationEnd : MonoBehaviour
{
    public void ShutDownApplication(int _num)
    {
        Application.Quit(_num);
    }
}
