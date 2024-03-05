using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using MyketPlugin;
using UnityEngine.UI;


public class MyketApiEventListener : MonoBehaviour
{
#if UNITY_ANDROID
  

	void OnEnable()
	{
		IABEventManager.connectedServiceSucceededEvent += connectedServiceSucceededEvent;
		IABEventManager.connectedServiceFailedEvent += connectedServiceFailedEvent;
		IABEventManager.myketUpdateAvailableEvent += myketUpdateAvailableEvent;
		IABEventManager.needInstallMyketEvent += needInstallMyketEvent;
        
		IABEventManager.updateIsAvailableEvent += updateIsAvailableEvent;
		IABEventManager.appAlreadyUpdatedEvent += appAlreadyUpdatedEvent;

		IABEventManager.userIsLoginEvent += userIsLoginEvent;
		IABEventManager.userIsNotLoginEvent += userIsNotLoginEvent;

		IABEventManager.userIdEvent += userIdEvent;

		IABEventManager.dataSavedEvent += dataSavedEvent;
		IABEventManager.dataNotSavedEvent += dataNotSavedEvent;

		IABEventManager.dataLoadedEvent += dataLoadedEvent;
		IABEventManager.dataNotLoadedEvent += dataNotLoadedEvent;

		IABEventManager.errorResponseEvent += errorResponseEvent;



	}

   
    void OnDisable()
	{
		IABEventManager.connectedServiceSucceededEvent -= connectedServiceSucceededEvent;
		IABEventManager.connectedServiceFailedEvent -= connectedServiceFailedEvent;
		IABEventManager.myketUpdateAvailableEvent -= myketUpdateAvailableEvent;
		IABEventManager.needInstallMyketEvent -= needInstallMyketEvent;
        
		IABEventManager.updateIsAvailableEvent -= updateIsAvailableEvent;
		IABEventManager.appAlreadyUpdatedEvent -= appAlreadyUpdatedEvent;

		IABEventManager.userIsLoginEvent -= userIsLoginEvent;
		IABEventManager.userIsNotLoginEvent -= userIsNotLoginEvent;

		IABEventManager.userIdEvent -= userIdEvent;

		IABEventManager.dataSavedEvent -= dataSavedEvent;
		IABEventManager.dataNotSavedEvent -= dataNotSavedEvent;

		IABEventManager.dataLoadedEvent -= dataLoadedEvent;
		IABEventManager.dataNotLoadedEvent -= dataNotLoadedEvent;
		
		IABEventManager.errorResponseEvent += errorResponseEvent;

	}


	//INITIAL CONNECT
    private void connectedServiceSucceededEvent(string message){
		ToastManager.showToast(message);
    }
    private void connectedServiceFailedEvent(string error){
		ToastManager.showToast(error);
    }
    private void myketUpdateAvailableEvent(string message){
		ToastManager.showToast(message);
    }
    private void needInstallMyketEvent(string message){
		ToastManager.showToast(message);
    }

	// CHECK UPDATE
	private void updateIsAvailableEvent(string message){
		ToastManager.showToast(message);
    }
	private void appAlreadyUpdatedEvent(string message){
		ToastManager.showToast(message);
    }

	// CHECK LOGIN
	private void userIsLoginEvent(string message){
		ToastManager.showToast(message);
    }
	private void userIsNotLoginEvent(string message){
		ToastManager.showToast(message);
    }

	// GET USER ID
	private void userIdEvent(string id){
		ToastManager.showToast("Id : " + id);
    }

	// SAVE DATA
	private void dataSavedEvent(string message){
		ToastManager.showToast(message);
    }
	private void dataNotSavedEvent(string error){
		ToastManager.showToast(error);
    }

	// LOAD DATA
	private void dataLoadedEvent(string message){
		ToastManager.showToast(message);
    }
	private void dataNotLoadedEvent(string error){
		ToastManager.showToast(error);
    }

	// ERROR RESPONSE
	private void errorResponseEvent(string error){
		ToastManager.showToast(error);
    }
	



#endif

}


