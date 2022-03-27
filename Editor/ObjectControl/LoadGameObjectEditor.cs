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
        /**
       * @fn public void OnInspectorGUI()
       * @brief InspectorのGUIを変更する関数。
       */
        public override void OnInspectorGUI()
        {

            base.OnInspectorGUI();

            var obj = target as LoadGameObject;

            Object targetObj = obj.baseGameObject;

            InputField<GameObject>(ref targetObj, "オブジェクトを生成する位置の基本となるオブジェクト");
            
            obj.baseGameObject = ((GameObject)targetObj);

        }
    }

}
