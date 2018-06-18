using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;　//　Loadsceneを使うために必要！！

public class ClearDirector : MonoBehaviour {
	void Update() {
        if (Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene("GameScene");
        }	
	}
}
