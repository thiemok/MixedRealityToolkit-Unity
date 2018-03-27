using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MixedRealityToolkit.UX.Buttons;

public class ButtonTest : MonoBehaviour {

    uint frame = 0;

	// Use this for initialization
	void Start () {
        Button button = this.GetComponent<Button>();
        button.OnButtonClicked += (target) => {
            Debug.LogFormat("Frame {0}\n{1}", frame, System.Environment.StackTrace);
        };
	}
	
	// Update is called once per frame
	void Update () {
        frame++;
	}
}
