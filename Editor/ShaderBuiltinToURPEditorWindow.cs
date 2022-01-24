using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class ShaderBuiltinTOURPEditorWindow : EditorWindow
{

    #region [数据成员]
    private string[] tabNames = new string[] { "结构", "Include文件", "光照模式", "变体", "预定义的着色器预处理宏", "内置的着色器辅助函数", "内置的着色器变量", "其他方法", "后期/特效" };
    private int selectedTabID;
    //搜索关键字
    private string searchText;
    public static string SEARCH_TEXT;
    #endregion
    #region 编缉器入口
    [MenuItem("Window/Builtin转到URP对照表... #T", false, -12)]
    public static void Open()
    {
        ShaderBuiltinTOURPEditorWindow window = GetWindow<ShaderBuiltinTOURPEditorWindow>();
        GUIContent content = new GUIContent();
        content.text = "Builtin转到URP对照表";
        window.titleContent = content;
        window.Show();
    }
    #endregion
    #region OnGUI
    void OnGUI()
    {
        DrawSearchGUI();
        EditorGUILayout.BeginHorizontal();
        {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox, GUILayout.Width(60), GUILayout.ExpandHeight(true));
            {
                //功能选择
                selectedTabID = GUILayout.SelectionGrid(selectedTabID, tabNames, 1);
            }
            EditorGUILayout.EndVertical();
            EditorGUILayout.BeginVertical();
            {
                switch (selectedTabID)
                {
                    case 0:
                        GUILayout.TextArea("0");
                        break;
                    case 1:
                        GUILayout.TextArea("1");
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:

                        break;
                    case 5:
                        break;
                }
            }
            EditorGUILayout.EndVertical();
        }
        EditorGUILayout.EndHorizontal();
        #region [搜索功能相关]
        void DrawSearchGUI()
        {
            GUILayout.BeginHorizontal();
            GUILayout.Space(100f);
            searchText = EditorGUILayout.TextField("", searchText, "SearchTextField");
            if (GUILayout.Button("", "SearchCancelButton", GUILayout.Width(18f)))
            {
                GUIUtility.keyboardControl = 0;
                searchText = string.Empty;
            }
            SEARCH_TEXT = searchText;

            GUILayout.Space(100f);
            GUILayout.EndHorizontal();
        }
        #endregion



























        if (GUILayout.Button("仅用于测试"))
        {

        }
        GUILayout.Label("Update:2022/1/15.Putao", EditorStyles.centeredGreyMiniLabel);


    }
    #endregion
}
