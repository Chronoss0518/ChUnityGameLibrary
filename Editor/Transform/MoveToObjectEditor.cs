/**
* @file MoveToObjectEditor.cs
* @brief MoveToObject�X�N���v�g��Inspector���J�X�^�}�C�Y��������
* @author Chronoss0518
* @date 2022/03/29
* @details MoveToObject�X�N���v�g�𑀍삵�₷���悤��Inspector���J�X�^�}�C�Y��������
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditor���p������MoveToObjectEditor
*/

namespace ChUnity.Transform
{

    [CustomEditor(typeof(MoveToObject))]
    public class MoveToObjectEditor : Common.GameObjectTargetSelectorEditor
    {

        private void OnEnable()
        {
            targetObjectDescription = "�ړ�����I�u�W�F�N�g";
        }

        /**
       * @fn public void OnInspectorGUI()
       * @brief Inspector��GUI��ύX����֐��B
       */
        public override Object InspectorGUI()
        {

            var obj = base.InspectorGUI() as MoveToObject;

            obj.moveTarget = (GameObject)InputField<GameObject>(obj.moveTarget, "�ړ���̃I�u�W�F�N�g");

            obj.speed = InputField(obj.speed, "�ړ����x");

            Line();

            Label("�ړ���");

            //BeginHorizontal();

            obj.xAxis =IsTrueToggle(obj.xAxis, "X��");
            obj.yAxis =IsTrueToggle(obj.yAxis, "Y��");
            obj.zAxis =IsTrueToggle(obj.zAxis, "Z��");

            //EndHorizontal();

            Line();

            return obj;
        }
    }

}
