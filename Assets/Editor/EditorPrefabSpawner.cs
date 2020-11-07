using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

[InitializeOnLoad]
class EditorPrefabSpawner
{
    static EditorPrefabSpawner()
    {
        EditorApplication.update += EditorUpdate;
    }

    static void EditorUpdate()
    {
        EnforcePrefabExistsInScene("command");
    }

    static bool ObjectInSceneWithName(string name)
    {
        foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
        {
            if (go.hideFlags == HideFlags.NotEditable || go.hideFlags == HideFlags.HideAndDontSave)
                continue;

            if (!EditorUtility.IsPersistent(go.transform.root.gameObject))
                continue;

            if (go.name.Equals(name))
                return true;
        }

        return false;
    }

    static void EnforcePrefabExistsInScene(string name)
    {
        if (GameObject.Find(name) == null)
        {
            GameObject application_prefab = Resources.Load<GameObject>(name);
            if (application_prefab == null)
            {
                Debug.LogError("Scene-Critical prefab could not be loaded: [" + name + "]");
                return;
            }

            GameObject new_required_object = PrefabUtility.InstantiatePrefab(application_prefab) as GameObject;
            new_required_object.name = name;
        }
    }
}