/**
* @file MoveToObjectEditor.cs
* @brief MoveToObjectスクリプトのInspectorをカスタマイズしたもの
* @author Chronoss0518
* @date 2022/03/29
* @details MoveToObjectスクリプトを操作しやすいようにInspectorをカスタマイズしたもの
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditorを継承したMoveToObjectEditor
*/

namespace ChUnity.Transform
{

    [CustomEditor(typeof(MoveToObject))]
    public class MoveToObjectEditor : Common.GameObjectTargetSelectorEditor
    {

        private void OnEnable()
        {
            targetObjectDescription = "移動するオブジェクト";
        }

        /**
       * @fn public void OnInspectorGUI()
       * @brief InspectorのGUIを変更する関数。
       */
        public override Object InspectorGUI()
        {

            var obj = base.InspectorGUI() as MoveToObject;

            obj.moveTarget = (GameObject)InputField<GameObject>(obj.moveTarget, "移動先のオブジェクト");

            obj.speed = InputField(obj.speed, "移動速度");

            Line();

            Label("移動軸");

            //BeginHorizontal();

            obj.xAxis =IsTrueToggle(obj.xAxis, "X軸");
            obj.yAxis =IsTrueToggle(obj.yAxis, "Y軸");
            obj.zAxis =IsTrueToggle(obj.zAxis, "Z軸");

            //EndHorizontal();

            Line();

            return obj;
        }
    }

}
