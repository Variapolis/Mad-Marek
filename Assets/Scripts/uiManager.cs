using UnityEngine;
using System.Collections;

public class uiManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void Play(){
		Application.LoadLevel ("Level1");
	}

    public void Play2()
    {
        Application.LoadLevel("Level2");
    }

    public void Play3()
    {
        Application.LoadLevel("Level3");
    }

    public void Play4()
    {
        Application.LoadLevel("Menu");
    }

    public void Pause(){

		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		}
		 else if (Time.timeScale == 0) {
			Time.timeScale = 1;		
		}
	}
}
