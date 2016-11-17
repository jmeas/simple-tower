public class Elevator : UnityEngine.MonoBehaviour {
  CinematicMode cinematicMode;
  UnityEngine.GameObject player;

  // How fast the elevator moves
  float elevatorSpeed = 2.6f;
  // This is the difference in the elevator and player's y position
  float playerHeightDiff = 0.0639f;

  void Start() {
    UnityEngine.GameObject cinematicModeObj = UnityEngine.GameObject.Find("CinematicMode");
    cinematicMode = cinematicModeObj.GetComponent<CinematicMode>();
    player = UnityEngine.GameObject.Find("ThirdPersonController");
  }

  System.Collections.IEnumerator MoveElevator(string direction) {
    float endDestination = direction == "down" ? 0.12f : 9.94f;
    yield return new MoveIEnumerator(this.gameObject, endDestination, elevatorSpeed);
    // Cinematic mode began while the elevator was going down. So we need to turn it off.
    if (direction == "down") {
      cinematicMode.ExitCinematicMode();
    }
  }

  System.Collections.IEnumerator MovePlayer(string direction) {
    float endDestination = direction == "down" ? 0.12f : 9.94f;
    endDestination += playerHeightDiff;
    yield return new MoveIEnumerator(this.player, endDestination, elevatorSpeed);
  }

  void OnTriggerEnter(UnityEngine.Collider col) {
    if (col.gameObject.name == "ThirdPersonController") {
      cinematicMode.EnterCinematicMode();
      StartCoroutine(MoveElevator("down"));
      StartCoroutine(MovePlayer("down"));
    }
  }

  // This is called by the child when the elevator has been exited
  // by the player.
  void ExitElevator() {
    StopCoroutine("MoveElevator");
    StartCoroutine(MoveElevator("up"));
  }
}
