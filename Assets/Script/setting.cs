using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setting : MonoBehaviour {
	public GameObject PopUp;
	public bool aktif;
	public GameObject quiz, materi, petunjuk, informasi;

	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDown(){
		PopUp.SetActive (aktif);
		quiz.SetActive (false);
		materi.SetActive (false);
		petunjuk.SetActive (false);
		informasi.SetActive (false);

	}

	public void exit (){
		SceneManager.LoadScene ("menu");
	}
	
	
}
