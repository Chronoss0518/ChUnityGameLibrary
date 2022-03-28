/**
* @file ObjectActivityEditor.cs
* @brief ObjectActivity�X�N���v�g��Inspector���J�X�^�}�C�Y��������
* @author Chronoss0518
* @date 2022/01/02
* @details ObjectActivity�X�N���v�g�𑀍삵�₷���悤��Inspector���J�X�^�}�C�Y��������
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditor���p������ObjectActivityEditor
*/

namespace ChUnity.ObjectControl
{

    [CustomEditor(typeof(ObjectActivity))]
    public class ObjectActivityEditor : Common.GameObjectTargetSelectorEditor
    {

        /**
       * @fn public void OnInspectorGUI()
       * @brief Inspector��GUI��ύX����֐��B
       */
        public override void OnInspectorGUI()
        {

            base.OnInspectorGUI();

            var obj = target as LoadGameObject;

            Object targetObj = obj.baseGameObject;

            targetObj = InputField<GameObject>(targetObj, "�I�u�W�F�N�g�𐶐�����ʒu�̊�{�ƂȂ�I�u�W�F�N�g");

            obj.baseGameObject = ((GameObject)targetObj);

        }
    }

}
