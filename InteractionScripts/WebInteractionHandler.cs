using UnityEngine;
using System.Collections;
using Awesomium.Core;
using Awesomium.Unity;

public class WebInteractionHandler : WebUIScript {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		JSObject myJSObject = webUI.CreateGlobalJavascriptObject ("myJSObject");
		if (myJSObject == null) {
			return;
		} 

		using (myJSObject) {
			myJSObject.Bind("onButtonClick", false, myJSMethodHandler);
		}
	}

	private void myJSMethodHandler(object sender, JavascriptMethodEventArgs args) {
		if (args.MethodName == "onButtonClick") {
			DebugConsole.Log("Workkii", "normal");
		}
	}
}
