/**
* @file LoadGameObjectEditor.cs
* @brief LoadGameObjectスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/01/02
* @details LoadGameObjectスクリプトを操作しやすいようにInspectorをカスタマイズしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditorを継承したLoadGameObjectEditor
*/

namespace ChUnity.ObjectControl
{


    [CustomEditor(typeof(LoadGameObject))]
    public class LoadGameObjectEditor : Common.GameObjectTargetSelectorEditor
    {

        protected void OnEnable()
        {
            targetObjectDescription = "生成するオブジェクト";
        }
        /**
       * @fn public void OnInspectorGUI()
       * @brief InspectorのGUIを変更する関数。
       */
        public override Object InspectorGUI()
        {

            var obj = base.InspectorGUI() as LoadGameObject;

            obj.baseGameObject = (GameObject)InputField<GameObject>(obj.baseGameObject, "オブジェクトを生成する位置の基本となるオブジェクト");

            BeginObjectUpdate();

            UpdateProperty(obj.baseGameObject, "baseObejct");

            EndObjectUpdate();

            return obj;
        }
    }

}
