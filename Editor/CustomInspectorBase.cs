/**
* @file CustomInspectorBase.cs
* @brief CustomInspectorを開発する際の基盤となるクラス
* @author Chronoss0518
* @date 2022/01/02
* @details UnityではInspectorの見た目を変更することが可能で、こちらを利用するとScriptごとのInspectoを開発する手間を軽減させることが可能
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/**
* @brief   Editorを継承したCustom Inspectorの開発を容易にするためのクラス。
* @details 必要だと思われる機能を内包したクラス。Editorも内包しているため、Attributeの「CustomEditor」のみ必要となる。
*/


namespace ChUnity
{
    public class CustomInspectorBase : Editor
    {

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //BaseFunction//

        /**
       * @fn void Line()
       * @brief Inspectorを区切るためのラインを作る。
       */
        protected void Line()
        {
            BoxSameWidthInspector(1);
        }

        /**
       * @fn void BoxSameWidthInspector(in float _height, in string _text = "")
       * @brief Inspectorの幅と同じサイズのBoxを作成する。
       */
        protected void BoxSameWidthInspector(in float _height, in string _text = "")
        {
            GUILayout.Box(_text, GUILayout.ExpandWidth(true), GUILayout.Height(_height));
        }

        /**
       * @fn void Label(in string _str)
       * @brief Inspector上に文字を書く
       */
        protected void Label(in string _str)
        {
            EditorGUILayout.LabelField(_str);
        }

        /**
       * @fn void HelpBox(in string _description, in MessageType _type = MessageType.Info)
       * @brief Helpboxを作成する
       */
        protected void HelpBox(in string _description, in MessageType _type = MessageType.Info)
        {
            if (string.IsNullOrWhiteSpace(_description)) return;

            EditorGUILayout.HelpBox(_description, _type);
        }

        /**
       * @fn void VerticalSpace(in float _size)
       * @brief Inspectorの項目と項目の間に空白を入れる。
       */
        protected void VerticalSpace(in float _size)
        {
            GUILayout.Space(_size);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //PairFunctions//

        /**
       * @fn void BeginToggleGroup(ref bool _flg,in string _name)
       * @brief 複数のBeginToggleGroupを設置して、終りにEndToggleGroupを置く
       */
        protected void BeginToggleGroup(ref bool _flg, in string _name)
        {
            EditorGUILayout.BeginToggleGroup(_name, _flg);
        }

        /**
       * @fn void EndToggleGroup()
       * @brief 複数のBeginToggleGroupを設置して、終りにEndToggleGroupを置く
       */
        protected void EndToggleGroup()
        {
            EditorGUILayout.EndToggleGroup();
        }

        /**
       * @fn void BeginHorizontal()
       * @brief 同じ高さにInspectorの機能を配置する。EndHorizontalを使用する前に利用する。
       */
        protected void BeginHorizontal()
        {
            EditorGUILayout.BeginHorizontal();
        }

        /**
       * @fn void EndHorizontal()
       * @brief 同じ高さにInspectorの機能を配置する。BeginHorizontalを使用した後に利用する。
       */
        protected void EndHorizontal()
        {
            EditorGUILayout.EndHorizontal();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //IsFunction//

        /**
       * @fn bool IsFoldOut(ref bool _flg, in string _name)
       * @brief 対象のグループを折りたためるようにし、グループが展開されており確認できることを確認する。
       */
        protected bool IsExtractFoldOut(ref bool _flg, in string _name)
        {
            return (_flg = EditorGUILayout.Foldout(_flg, _name));
        }

        /**
       * @fn bool IsPushButton(in string _name)
       * @brief Buttonを表示し、Buttonが押されたかを確認する。
       */
        protected bool IsPushButton(in string _name)
        {
            return GUILayout.Button(_name);
        }

        /**
       * @fn bool Toggle(ref bool _flg, in string _title, in string _description = "")
       * @brief チェックされていることを確認する
       */
        protected bool IsTrueToggle(ref bool _flg, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _flg = EditorGUILayout.Toggle(_flg);

            return _flg;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //Slider//

        /**
       * @fn void Slider(ref float _val, in float _low, in float _high, in string _title, in string _description = "")
       * @brief float型の値をバーをスライドして調節させる。
       */
        protected void Slider(ref float _val, in float _low, in float _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.Slider(_val, _low, _high);
        }

        /**
       * @fn void Slider(ref int _val, in int _low, in int _high, in string _title, in string _description = "")
       * @brief int型の値をバーをスライドして調節させる。
       */
        protected void Slider(ref int _val, in int _low, in int _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.IntSlider(_val, _low, _high);
        }

        /**
       * @fn void Slider(ref Vector2 _val, in Vector2 _low, in Vector2 _high, in string _title, in string _description = "")
       * @brief Vector2型の値をバーをスライドして調節させる。
       */
        protected void Slider(ref Vector2 _val, in Vector2 _low, in Vector2 _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            BeginHorizontal();
            Slider(ref _val.x, _low.x, _high.x, "x");
            EndHorizontal();

            BeginHorizontal();
            Slider(ref _val.y, _low.y, _high.y, "y");
            EndHorizontal();

        }

        /**
       * @fn void Slider(ref Vector2Int _val, in Vector2Int _low, in Vector2Int _high, in string _title, in string _description = "")
       * @brief Vector2Int型の値をバーをスライドして調節させる。
       */
        protected void Slider(ref Vector2Int _val, in Vector2Int _low, in Vector2Int _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            int tmp;
            tmp = _val.x;
            BeginHorizontal();
            Slider(ref tmp, _low.x, _high.x, "x");
            EndHorizontal();
            _val.x = tmp;

            tmp = _val.y;
            BeginHorizontal();
            Slider(ref tmp, _low.y, _high.y, "y");
            EndHorizontal();
            _val.y = tmp;
        }

        /**
       * @fn void Slider(ref Vector3 _val, in Vector3 _low, in Vector3 _high, in string _title, in string _description = "")
       * @brief Vector3型の値をバーをスライドして調節させる。
       */
        protected void Slider(ref Vector3 _val, in Vector3 _low, in Vector3 _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            BeginHorizontal();
            Slider(ref _val.x, _low.x, _high.x, "x");
            EndHorizontal();

            BeginHorizontal();
            Slider(ref _val.y, _low.y, _high.y, "y");
            EndHorizontal();

            BeginHorizontal();
            Slider(ref _val.z, _low.z, _high.z, "z");
            EndHorizontal();
        }

        /**
       * @fn void Slider(ref Vector3Int _val, in Vector3Int _low, in Vector3Int _high, in string _title, in string _description = "")
       * @brief Vector3Int型の値をバーをスライドして調節させる。
       */
        protected void Slider(ref Vector3Int _val, in Vector3Int _low, in Vector3Int _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            int tmp;
            tmp = _val.x;
            BeginHorizontal();
            Slider(ref tmp, _low.x, _high.x, "x");
            EndHorizontal();
            _val.x = tmp;

            tmp = _val.y;
            BeginHorizontal();
            Slider(ref tmp, _low.y, _high.y, "y");
            EndHorizontal();
            _val.y = tmp;

            tmp = _val.z;
            BeginHorizontal();
            Slider(ref tmp, _low.z, _high.z, "z");
            EndHorizontal();
            _val.z = tmp;
        }

        /**
       * @fn void Slider(ref Vector4 _val, in Vector4 _low, in Vector4 _high, in string _title, in string _description = "")
       * @brief Vector4型の値をバーをスライドして調節させる。
       */
        protected void Slider(ref Vector4 _val, in Vector4 _low, in Vector4 _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);

            BeginHorizontal();
            Slider(ref _val.x, _low.x, _high.x, "x");
            EndHorizontal();

            BeginHorizontal();
            Slider(ref _val.y, _low.y, _high.y, "y");
            EndHorizontal();

            BeginHorizontal();
            Slider(ref _val.z, _low.z, _high.z, "z");
            EndHorizontal();

            BeginHorizontal();
            Slider(ref _val.w, _low.w, _high.w, "w");
            EndHorizontal();
        }

        /**
       * @fn void RangeSlider(ref float _lowVal, ref float _highVal, in float _low, in float _high, in string _title, in string _description = "")
       * @brief float型の範囲情報を取得する
       */
        protected void RangeSlider(ref float _lowVal, ref float _highVal, in float _low, in float _high, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            EditorGUILayout.MinMaxSlider(ref _lowVal, ref _highVal, _low, _high);
        }

        /**
       * @fn void RangeSlider(ref Vector2 _val, in Vector2 _range, in string _title, in string _description = "")
       * @brief Vector2型の範囲情報(xがlow、yがhigh)を取得する
       */
        protected void RangeSlider(ref Vector2 _val, in Vector2 _range, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            float lowVal = _val.x;
            float highVal = _val.y;
            float low = _range.x;
            float high = _range.y;
            EditorGUILayout.MinMaxSlider(ref lowVal, ref highVal, low, high);

            _val.x = lowVal;
            _val.y = highVal;

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //InputField//

        /**
       * @fn void InputField(ref string _val, in string _title, in string _description = "")
       * @brief Textを入力する
       */
        protected void InputField(ref string _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.TextField(_val);
        }

        /**
       * @fn void InputField(ref int _val, in string _title, in string _description = "")
       * @brief Intを入力する
       */
        protected void InputField(ref int _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.IntField(_val);
        }

        /**
       * @fn void InputField(ref float _val, in string _title, in string _description = "")
       * @brief Intを入力する
       */
        protected void InputField(ref float _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.FloatField(_val);
        }

        /**
       * @fn void InputField(ref Vector2 _val, in string _title, in string _description = "")
       * @brief Vector2を入力する
       */
        protected void InputField(ref Vector2 _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.Vector2Field("", _val);
        }

        /**
       * @fn void InputField(ref Vector2Int _val, in string _title, in string _description = "")
       * @brief Vector2を入力する
       */
        protected void InputField(ref Vector2Int _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.Vector2IntField("", _val);
        }

        /**
       * @fn void InputField(ref Vector3 _val, in string _title, in string _description = "")
       * @brief Vector2を入力する
       */
        protected void InputField(ref Vector3 _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.Vector3Field("", _val);
        }

        /**
       * @fn void InputField(ref Vector3Int _val, in string _title, in string _description = "")
       * @brief Vector2を入力する
       */
        protected void InputField(ref Vector3Int _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.Vector3IntField("", _val);
        }

        /**
       * @fn void InputField(ref Vector4 _val, in string _title, in string _description = "")
       * @brief Vector2を入力する
       */
        protected void InputField(ref Vector4 _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.Vector4Field("", _val);
        }

        /**
       * @fn void InputField(ref Object _val, in string _title, in string _description = "")
       * @brief Objectを入力する
       */
        protected void InputField<T>(ref Object _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.ObjectField("", _val, typeof(T), false);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //Popup//

        /**
       * @fn void EnumPopup(ref System.Enum _val, in string _title, in string _description = "")
       * @brief Enumを選択させるポップアップを表示
       */
        protected void EnumPopup(ref System.Enum _val, in string _title, in string _description = "")
        {
            Label(_title);
            HelpBox(_description);
            _val = EditorGUILayout.EnumPopup("", _val);
        }


    }

}
