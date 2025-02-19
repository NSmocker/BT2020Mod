using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR
public class ProBuilderCustomWindow : EditorWindow
{
    private string customText = "Hello, Unity!"; // Текст, який можна кастомізувати в вкладці

    // Додаємо вкладку до меню "Window"
    [MenuItem("Window/Silver Echo/ProBuilder Custom Window")]
    public static void ShowWindow()
    {
        // Відкриваємо або створюємо вікно
        GetWindow<ProBuilderCustomWindow>("Custom Tab");
    }

    private void OnGUI()
    {
        // Додаємо текстове поле для введення кастомного тексту
        GUILayout.Label("Pro Builder Custom Window", EditorStyles.boldLabel);
        
        GUILayout.BeginHorizontal();
        // Додаємо кнопку
        if (GUILayout.Button("Dublicate Faces"))
        {
            // Дія при натисканні кнопки
            EditorApplication.ExecuteMenuItem("Tools/ProBuilder/Geometry/Duplicate Faces");
        }
         if (GUILayout.Button("Delete Faces"))
        {
            // Дія при натисканні кнопки
            EditorApplication.ExecuteMenuItem("Tools/ProBuilder/Geometry/Delete Faces");
        }
         if (GUILayout.Button("Bridge Edges"))
        {
            // Дія при натисканні кнопки
            EditorApplication.ExecuteMenuItem("Tools/ProBuilder/Geometry/Bridge Edges");
        }
         if (GUILayout.Button("Center Pivot"))
        {
            // Дія при натисканні кнопки
            EditorApplication.ExecuteMenuItem("Tools/ProBuilder/Object/Center Pivot");
        }
          if (GUILayout.Button("Merge Objects"))
        {
            // Дія при натисканні кнопки
            EditorApplication.ExecuteMenuItem("Tools/ProBuilder/Object/Merge Objects");
        }
        if (GUILayout.Button("Set object to view Position"))
        {
            
            if (SceneView.lastActiveSceneView == null)
            {
                Debug.LogError("No active Scene View found.");
                return;
            }
            GameObject selectedObject = Selection.activeGameObject;

            // Get the SceneView camera's transform
            Transform cameraTransform = SceneView.lastActiveSceneView.camera.transform;

            Undo.RecordObject(selectedObject.transform, "Move Object To View");

            // Move the object to the camera's position and maintain its original rotation
            selectedObject.transform.position = cameraTransform.position;

          
        }
        
           GUILayout.EndHorizontal();
    }
}
#endif