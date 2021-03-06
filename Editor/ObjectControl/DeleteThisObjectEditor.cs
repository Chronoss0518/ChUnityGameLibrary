/**
* @file DeleteThisObjectEditor.cs
* @brief DeleteThisObjectスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/01/02
* @details DeleteThisObjectスクリプトを操作しやすいようにInspectorをカスタマイズしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditorを継承したDeleteThisObjectEditor
*/

namespace ChUnity.ObjectControl
{


    [CustomEditor(typeof(DeleteThisObject))]
    public class DeleteThisObjectEditor : Common.GameObjectTargetSelectorEditor
    {

        /**
       * @fn public void OnInspectorGUI()
       * @brief InspectorのGUIを変更する関数。
       */
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
        }
    }

}
