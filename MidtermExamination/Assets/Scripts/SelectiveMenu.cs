using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectiveMenu : MonoBehaviour {
[SerializeField] Button _stage1Button;
[SerializeField] Button _stage2Button;
[SerializeField] Button _backButton;

 // Use this for initialization
 void Start () {
_stage1Button.onClick.AddListener (
 delegate{ButtonStage1Click(_stage1Button);});
_stage2Button.onClick.AddListener (
 delegate{ButtonStage2Click(_stage2Button);});

 _backButton.onClick.AddListener
 (delegate { BackToMainMenuButtonClick(_backButton); });
 }

 // Update is called once per frame
 void Update () {


 }
 public void ButtonStage1Click(Button button) {
 SceneManager.LoadScene("Scene1");
 }
 public void ButtonStage2Click(Button button) {
 SceneManager.LoadScene("Scene2");
 }
 
 public void BackToMainMenuButtonClick(Button button) {
 SceneManager.UnloadSceneAsync("SceneSelective");
 SceneManager.LoadScene("SceneMainMenu");
 }
 }