/**
* @file LoadGameObjectEditor.cs
* @brief LoadGameObject�X�N���v�g��Inspector���J�X�^�}�C�Y��������
* @author Chronoss0518
* @date 2022/01/02
* @details LoadGameObject�X�N���v�g�𑀍삵�₷���悤��Inspector���J�X�^�}�C�Y��������
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   GameObjectTargetSelectorEditor���p������LoadGameObjectEditor
*/

namespace ChUnity.ObjectControl
{


    [CustomEditor(typeof(LoadGameObject))]
    public class LoadGameObjectEditor : Common.GameObjectTargetSelectorEditor
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

            InputField<GameObject>(ref targetObj, "�I�u�W�F�N�g�𐶐�����ʒu�̊�{�ƂȂ�I�u�W�F�N�g");
            
            obj.baseGameObject = ((GameObject)targetObj);

        }
    }

}
