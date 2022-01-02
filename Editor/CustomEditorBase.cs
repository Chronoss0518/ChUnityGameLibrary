using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class CustomEditorBase : Editor
{

    protected void Line()
    {
        BoxSameWidthInspector(1);
    }

    protected void BoxSameWidthInspector(float _height, string _text = "")
    {
        GUILayout.Box(_text, GUILayout.ExpandWidth(true), GUILayout.Height(_height));
    }

    protected void StartGroup()
    {
        EditorGUILayout.BeginHorizontal();
    }

    protected void EndGroup()
    {
        EditorGUILayout.EndHorizontal();
    }

    protected bool IsFoldOut(ref bool _flg,in string _name)
    {
        return (_flg =  EditorGUILayout.Foldout(_flg, _name));
    }

    protected void Slider(ref float _val,in float _low,in float _high,in string _title,in string _description = "")
    {
        Label(_title);
        _val = EditorGUILayout.Slider(_val, _low, _high);
    }
    protected void Slider(ref int _val, in int _low, in int _high,in string _title,in string _description = "")
    {
        Label(_title);
        _val = EditorGUILayout.IntSlider(_val, _low, _high);
    }
    protected void Slider(ref Vector2 _val,in Vector2 _low,in Vector2 _high,in string _title,in string _description = "")
    {
        Label(_title);

        StartGroup();
        Slider(ref _val.x, _low.x, _high.x, "x");
        EndGroup();

        StartGroup();
        Slider(ref _val.y, _low.y, _high.y, "y");
        EndGroup();

    }
    protected void Slider(ref Vector2Int _val, in Vector2Int _low, in Vector2Int _high, in string _title,in string _description = "")
    {
        Label(_title);
        int tmp;
        tmp = _val.x;
        StartGroup();
        Slider(ref tmp, _low.x, _high.x, "x");
        EndGroup();
        _val.x = tmp;

        tmp = _val.y;
        StartGroup();
        Slider(ref tmp, _low.y, _high.y, "y");
        EndGroup();
        _val.y = tmp;
    }
    protected void Slider(ref Vector3 _val,in Vector3 _low,in Vector3 _high,in string _title,in string _description = "")
    {
        Label(_title);

        StartGroup();
        Slider(ref _val.x, _low.x, _high.x, "x");
        EndGroup();

        StartGroup();
        Slider(ref _val.y, _low.y, _high.y, "y");
        EndGroup();

        StartGroup();
        Slider(ref _val.z, _low.z, _high.z, "z");
        EndGroup();
    }
    protected void Slider(ref Vector3Int _val,in Vector3Int _low, in Vector3Int _high,in string _title, in string _description = "")
    {
        Label(_title);
        int tmp;
        tmp = _val.x;
        StartGroup();
        Slider(ref tmp, _low.x, _high.x, "x");
        EndGroup();
        _val.x = tmp;

        tmp = _val.y;
        StartGroup();
        Slider(ref tmp, _low.y, _high.y, "y");
        EndGroup();
        _val.y = tmp;

        tmp = _val.z;
        StartGroup();
        Slider(ref tmp, _low.z, _high.z, "z");
        EndGroup();
        _val.z = tmp;
    }
    protected void Slider(ref Vector4 _val,in Vector4 _low,in Vector4 _high,in string _title,in string _description = "")
    {
        Label(_title);

        StartGroup();
        Slider(ref _val.x, _low.x, _high.x, "x");
        EndGroup();

        StartGroup();
        Slider(ref _val.y, _low.y, _high.y, "y");
        EndGroup();

        StartGroup();
        Slider(ref _val.z, _low.z, _high.z, "z");
        EndGroup();

        StartGroup();
        Slider(ref _val.w, _low.w, _high.w, "w");
        EndGroup();
    }
    protected void RangeSlider(ref float _lowVal,ref float _highVal, in float _low, in float _high, in string _title, in string _description = "")
    {
        Label(_title);
        EditorGUILayout.MinMaxSlider(ref _lowVal,ref _highVal,_low ,_high);
    }

    protected void Label(in string _str)
    {
        EditorGUILayout.LabelField(_str);
    }

    protected void HelpBox(in string _description)
    {
        if (_description == null) return;


    }

    protected bool Button(in string _name)
    {
        return GUILayout.Button(_name);
    }

    protected void VerticalSpace(in float _size)
    {
        GUILayout.Space(_size);
    }

}
