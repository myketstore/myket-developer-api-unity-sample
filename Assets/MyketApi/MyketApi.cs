
using UnityEngine;

#if UNITY_ANDROID
namespace MyketPlugin
{
    public class MyketApi
    {
        private static AndroidJavaObject mPlugin;

        public static string GetVersion()
        {
            return "1.0.3";
        }

        static MyketApi()
        {
            if (Application.platform != RuntimePlatform.Android)
                return;

            // Get the plugin instance
            using (var pluginClass = new AndroidJavaClass("ir.myket.developerapi.MyketIABPlugin"))
                mPlugin = pluginClass.CallStatic<AndroidJavaObject>("instance");
        }


        public static void initialConnect()
        {
            Debug.Log("InitialConnect");
            if (Application.platform != RuntimePlatform.Android)
                return;

            
            mPlugin.Call("initialConnect");
        }


        public static void checkUpdate()
        {
            Debug.Log("checkUpdate");
            if (Application.platform != RuntimePlatform.Android)
                return;

            
            mPlugin.Call("checkUpdate");
        }


        public static void isUserLogin()
        {
            Debug.Log("isUserLogin");
            if (Application.platform != RuntimePlatform.Android)
                return;

            
            mPlugin.Call("checkLogin");
        }


        public static void getUserId()
        {
            Debug.Log("getUserId");
            if (Application.platform != RuntimePlatform.Android)
                return;

            
            mPlugin.Call("getUserId");
        }


        public static void saveData(string value)
        {
            Debug.Log("saveData");
            if (Application.platform != RuntimePlatform.Android)
                return;

            
            mPlugin.Call("saveData", value);
        }


        public static void loadData()
        {
            Debug.Log("loadData");
            if (Application.platform != RuntimePlatform.Android)
                return;

            
            mPlugin.Call("loadData");
        }


    }
}

#endif
