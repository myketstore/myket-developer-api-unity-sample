using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

#if UNITY_ANDROID

namespace MyketPlugin
{
    public class IABEventManager : AbstractManager
    {

        public static event Action<string> connectedServiceSucceededEvent;
        public static event Action<string> connectedServiceFailedEvent;
        public static event Action<string> myketUpdateAvailableEvent;
        public static event Action<string> needInstallMyketEvent;

        public static event Action<string> updateIsAvailableEvent;
        public static event Action<string> appAlreadyUpdatedEvent;

        public static event Action<string> userIsLoginEvent;
        public static event Action<string> userIsNotLoginEvent;

        public static event Action<string> userIdEvent;

        public static event Action<string> dataSavedEvent;
        public static event Action<string> dataNotSavedEvent;

        public static event Action<string> dataLoadedEvent;
        public static event Action<string> dataNotLoadedEvent;

        public static event Action<string> errorResponseEvent;


        static IABEventManager(){
            initialize(typeof(IABEventManager));
        }


        // INITIAL CONNECT
        public void connectedServiceSucceeded(string message){
            connectedServiceSucceededEvent.SafeInvoke(message);
        }
         public void connectedServiceFailed(string error){
            connectedServiceFailedEvent.SafeInvoke(error);
        }
        public void myketUpdateAvailable(string message){
            myketUpdateAvailableEvent.SafeInvoke(message);
        }
         public void needInstallMyket(string message){
            needInstallMyketEvent.SafeInvoke(message);
        }


        // CHECK UPDATE
        public void updateIsAvailable(string message){
            updateIsAvailableEvent.SafeInvoke(message);
        }
        public void appAlreadyUpdated(string message){
            appAlreadyUpdatedEvent.SafeInvoke(message);
        }


        // CHECK LOGIN
        public void userIsLogin(string message){
            userIsLoginEvent.SafeInvoke(message);
        }
        public void userIsNotLogin(string error){
            userIsNotLoginEvent.SafeInvoke(error);
        }


        // GET USER ID
        public void userId(string id){
            userIdEvent.SafeInvoke(id);
        }

       
        // SAVE DATA
        public void dataSaved(string message){
            dataSavedEvent.SafeInvoke(message);
        }
        public void dataNotSaved(string error){
            dataNotSavedEvent.SafeInvoke(error);
        }


        // LOAD DATA
        public void dataLoaded(string message){
            dataLoadedEvent.SafeInvoke(message);
        }
        public void dataNotLoaded (string error){
            dataNotLoadedEvent.SafeInvoke(error);
        }


        // ERROR RESPONSE
        public void errorResponse(string error){
            errorResponseEvent.SafeInvoke(error);
        }
       
    }
}

#endif
