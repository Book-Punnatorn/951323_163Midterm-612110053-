﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsMenu : MonoBehaviour {
[SerializeField] Button _backButton;
 // Use this for initialization
 void Start () {

 _backButton.onClick.AddListener
 (delegate { BackToMainMenuButtonClick(_backButton); });
 }

 // Update is called once per frame
 void Update () {

 }

 public void BackToMainMenuButtonClick(Button button) {
 SceneManager.UnloadSceneAsync("SceneCredits");
 SceneManager.LoadScene("SceneMainMenu");
 }
 }