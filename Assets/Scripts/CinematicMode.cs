﻿using UnityStandardAssets.Characters.ThirdPerson;

public class CinematicMode : UnityEngine.MonoBehaviour {
  bool cinematicModeActive = false;
  bool enterCinematicMode = false;
  bool exitCinematicMode = false;
  int barSpeed = 400;
  int barHeight = 100;

  UnityEngine.Rect topBar;
  UnityEngine.Rect bottomBar;
  static UnityEngine.Texture2D _staticRectTexture;
  static UnityEngine.GUIStyle _staticRectStyle;
  ThirdPersonUserControlCustom userControl;

  void Start() {
    topBar = new UnityEngine.Rect(0, -100, UnityEngine.Screen.width, barHeight);
    bottomBar = new UnityEngine.Rect(0, UnityEngine.Screen.height, UnityEngine.Screen.width, barHeight);

    UnityEngine.GameObject player = UnityEngine.GameObject.Find("ThirdPersonController");
    userControl = player.GetComponent<ThirdPersonUserControlCustom>();
  }

  void Update() {
    if (enterCinematicMode) {
      if (topBar.y != 0) {
        topBar.y = UnityEngine.Mathf.MoveTowards(topBar.y, 0, barSpeed * UnityEngine.Time.deltaTime);
        bottomBar.y = UnityEngine.Mathf.MoveTowards(bottomBar.y, UnityEngine.Screen.height - 100, barSpeed * UnityEngine.Time.deltaTime);
      } else {
        enterCinematicMode = false;
      }
    } else if (exitCinematicMode) {
      if (topBar.y != -100) {
        topBar.y = UnityEngine.Mathf.MoveTowards(topBar.y, -100, barSpeed * UnityEngine.Time.deltaTime);
        bottomBar.y = UnityEngine.Mathf.MoveTowards(bottomBar.y, UnityEngine.Screen.height, barSpeed * UnityEngine.Time.deltaTime);
      } else {
        userControl.enableMovement();
        cinematicModeActive = false;
        exitCinematicMode = false;
      }
    }
  }

  public void EnterCinematicMode() {
    userControl.disableMovement();
    exitCinematicMode = false;
    enterCinematicMode = true;
    cinematicModeActive = true;
  }

  public void ExitCinematicMode() {
    exitCinematicMode = true;
    enterCinematicMode = false;
  }

  void OnGUI() {
    if (!cinematicModeActive) {
      return;
    }
    if (_staticRectTexture == null) {
      _staticRectTexture = new UnityEngine.Texture2D( 1, 1 );
    }
    if (_staticRectStyle == null) {
      _staticRectStyle = new UnityEngine.GUIStyle();
    }
    _staticRectTexture.SetPixel( 0, 0, UnityEngine.Color.black );
    _staticRectTexture.Apply();

    _staticRectStyle.normal.background = _staticRectTexture;

    UnityEngine.GUI.Box(topBar, UnityEngine.GUIContent.none, _staticRectStyle);
    UnityEngine.GUI.Box(bottomBar, UnityEngine.GUIContent.none, _staticRectStyle);
  }
}
