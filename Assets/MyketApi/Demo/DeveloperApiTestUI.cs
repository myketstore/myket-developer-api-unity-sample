using UnityEngine;

using MyketPlugin;

public class DeveloperApiTestUI : MonoBehaviour
{
#if UNITY_ANDROID

     Vector2 scrollPosition = Vector2.zero;

    void OnGUI()
    {

        GUILayout.BeginArea(new Rect(10f, 10f, Screen.width - 20f, Screen.height - 20f));
       
        scrollPosition = GUILayout.BeginScrollView(scrollPosition);

        GUI.skin.button.fixedHeight = Screen.height/20;
        GUI.skin.button.fontSize = 20;


        if (Button("Initial connect"))
        {
            MyketApi.initialConnect();
        }

          if (Button("Get update state"))
        {
            MyketApi.checkUpdate();
        }

        if (Button("Is user login ?"))
        {
            MyketApi.isUserLogin();
        }

        if (Button("Get user unique id"))
        {
            MyketApi.getUserId();
        }

        if (Button("Save payload"))
        {
            MyketApi.saveData("MY VALUE");
        }

        if (Button("Load payload"))
        {
            MyketApi.loadData();
        }
        
        GUILayout.EndScrollView();
        GUILayout.EndArea();


    }

    bool Button(string label)
    {
        GUILayout.Space(5);
        return GUILayout.Button(label);
    }

#endif

}

