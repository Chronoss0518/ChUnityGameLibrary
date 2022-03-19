using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChUnity.Common
{
    public class LoadGameObject : GameObjectTargetSelector
    {
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
            if (targetObject == null) return;

            Instantiate(targetObject);
        }

        public void LoadObject(GameObject _targetObjectPosition)
        {
            if (targetObject == null) return;

            Instantiate(targetObject, _targetObjectPosition.transform);
        }

        public void LoadObjectUnChild(GameObject _targetObjectPosition)
        {
            if (targetObject == null) return;

            Instantiate(targetObject, _targetObjectPosition.transform.position, _targetObjectPosition.transform.rotation);
        }

    }

}
