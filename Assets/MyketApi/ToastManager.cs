using UnityEngine;

public static class ToastManager
{
    private static AndroidJavaObject currentActivity;
    private static string toastString;

   

    public static void showToast(string toastString)
    {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

        currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        ToastManager.toastString = toastString;

        currentActivity.Call("runOnUiThread", new AndroidJavaRunnable(androidToast));
    }

    private static void androidToast()
    {
        Debug.Log("Running on UI thread");
        AndroidJavaObject context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");
        AndroidJavaClass toastClass = new AndroidJavaClass("android.widget.Toast");
        AndroidJavaObject javaString = new AndroidJavaObject("java.lang.String", toastString);
        AndroidJavaObject toast = toastClass.CallStatic<AndroidJavaObject>("makeText", context, javaString, toastClass.GetStatic<int>("LENGTH_SHORT"));
        toast.Call("show");
    }
}
