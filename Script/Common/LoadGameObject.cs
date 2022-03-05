using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChUnity.Common
{
    public class LoadGameObject : MonoBehaviour
    {
        public GameObject loadObject = null;

        public void LoadResourceObject(string _path)
        {
            var obj = (GameObject)Resources.Load(_path);

            Instantiate(obj);

        }

        public void LoadResourceObject(string _path, Vector3 _positino, Quaternion _rotation)
        {
            var obj = (GameObject)Resources.Load(_path);

            Instantiate(obj, _positino, _rotation);

        }

        public void LoadResourceObject(string _path,GameObject _targetObjectPosition)
        {
            var obj = (GameObject)Resources.Load(_path);

            Instantiate(obj, _targetObjectPosition.transform);

        }


        public void LoadObject()
        {
            if (loadObject == null) return;

            Instantiate(loadObject);
        }

        public void LoadObject(GameObject _targetObjectPosition)
        {
            if (loadObject == null) return;

            Instantiate(loadObject, _targetObjectPosition.transform);
        }

        public void LoadObjectUnChild(GameObject _targetObjectPosition)
        {
            if (loadObject == null) return;

            Instantiate(loadObject, _targetObjectPosition.transform.position, _targetObjectPosition.transform.rotation);
        }

    }

}
