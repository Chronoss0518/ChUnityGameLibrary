/**
* @file ObjectActivityEditor.cs
* @brief ObjectActivityスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/03/29
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

        private void OnEnable()
        {
            targetObjectDescription = "有効・無効を操作する対象オブジェクト";
        }

        /**
       * @fn public void OnInspectorGUI()
       * @brief InspectorのGUIを変更する関数。
       */
        public override Object InspectorGUI()
        {
            return base.InspectorGUI();
        }
    }

}
