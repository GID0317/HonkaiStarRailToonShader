using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class EnableTexturePreProcess
{
    [MenuItem("Honkai Star Rail/�ʲ�Ԥ����/�����ʲ�Ԥ����", true)]
    public static bool CheckEnablePreProcess()
    {
        return !EditorPrefs.GetBool("EnableTexturePreProcess", false);
    }

    [MenuItem("Honkai Star Rail/�ʲ�Ԥ����/�����ʲ�Ԥ����", false)]
    public static void EnablePreProcess()
    {
        EditorPrefs.SetBool("EnableTexturePreProcess", true);
    }

    [MenuItem("Honkai Star Rail/�ʲ�Ԥ����/�ر��ʲ�Ԥ����", true)]
    public static bool CheckDisablePreProcess()
    {
        return EditorPrefs.GetBool("EnableTexturePreProcess", false);
    }

    [MenuItem("Honkai Star Rail/�ʲ�Ԥ����/�ر��ʲ�Ԥ����", false)]
    public static void DisablePreProcess()
    {
        EditorPrefs.SetBool("EnableTexturePreProcess", false);
    }
}
