using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class MainMenuControlScript : MonoBehaviour {

//Declarations section
[SerializeField] Button _startButton;
[SerializeField] Button _optionsButton;
[SerializeField] Button _creditsButton;
[SerializeField] Button _exitButton;
 //Inside Start() method
  void Start () {
 _startButton.onClick.AddListener (
 delegate{StartButtonClick(_startButton);});
 _optionsButton.onClick.AddListener (
 delegate{OptionsButtonClick(_optionsButton);});
 _creditsButton.onClick.AddListener (
delegate{CreditsButtonClick(_creditsButton);});
 _exitButton.onClick.AddListener (
delegate{ExitButtonClick(_exitButton);});
 }

 // Update is called once per frame
 void Update () {
 }

 public void StartButtonClick(Button button) {
 SceneManager.LoadScene("SceneSelective");
 }

 public void OptionsButtonClick(Button button) {
 if (!GameApplicationManager.Instance.IsOptionMenuActive)
 {
 SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
 GameApplicationManager.Instance.IsOptionMenuActive = true;
 }
 }

 public void CreditsButtonClick(Button button) {
 SceneManager.LoadScene("SceneCredits");
 }

 public void ExitButtonClick(Button button) {
 Application.Quit();
 }
 }