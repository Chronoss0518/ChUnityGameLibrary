/**
* @file ObjectActivityEditor.cs
* @brief ObjectActivityスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/01/02
* @details ObjectActivityスクリプトを操作しやすいようにInspectorをカスタマイズしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditorを継承したObjectActivityEditor
*/

namespace ChUnity.ObjectControl
{

    [CustomEditor(typeof(ObjectActivity))]
    public class ObjectActivityEditor : Common.GameObjectTargetSelectorEditor
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

            targetObj = InputField<GameObject>(targetObj, "オブジェクトを生成する位置の基本となるオブジェクト");

            obj.baseGameObject = ((GameObject)targetObj);

        }
    }

}
