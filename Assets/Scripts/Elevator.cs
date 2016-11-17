public class Elevator : UnityEngine.MonoBehaviour {
  CinematicMode cinematicMode;
  UnityEngine.GameObject player;

  // The time it takes the elevator to move up or down, in seconds
  float transitionDuration = 1.5f;
  // This is the difference in the elevator and player's y position
  float playerHeightDiff = 0.0639f;

  void Start() {
    UnityEngine.GameObject cinematicModeObj = UnityEngine.GameObject.Find("CinematicMode");
    cinematicMode = cinematicModeObj.GetComponent<CinematicMode>();
    player = UnityEngine.GameObject.Find("ThirdPersonController");
  }

  System.Collections.IEnumerator MoveElevator(string direction) {
    float endY = direction == "down" ? 0.12f : 9.94f;
    UnityEngine.Vector3 destination =  new UnityEngine.Vector3(this.transform.position.x, endY, this.transform.position.z);
    yield return new MoveIEnumerator(this.gameObject, destination, transitionDuration);
    // Cinematic mode began while the elevator was going down. So we need to turn it off.
    if (direction == "down") {
      cinematicMode.ExitCinematicMode();
    }
  }

  System.Collections.IEnumerator MovePlayer(string direction) {
    float endY = direction == "down" ? 0.12f : 9.94f;
    endY += playerHeightDiff;
    UnityEngine.Vector3 destination =  new UnityEngine.Vector3(player.transform.position.x, endY, player.transform.position.z);
    yield return new MoveIEnumerator(player, destination, transitionDuration);
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
