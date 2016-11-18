public class Elevator : UnityEngine.MonoBehaviour {
  CinematicMode cinematicMode;
  UnityEngine.GameObject player;

  // The time it takes the elevator to move up or down, in seconds
  float transitionDuration = 1.5f;
  // This is the difference in the elevator and player's y position
  float playerHeightDiff = 0.0639f;
  // The type of easing to use for the elevator moving up and down. For options,
  // see Transition.cs
  string easingFunction = "Linear";
  // Whether the elevator is up or down. This can be used to prevent weird bugs where it, say,
  // tries to go down when it's already down.
  bool isLocatedUp = true;

  System.Collections.Generic.Dictionary<string, float> elevatorPositions = new System.Collections.Generic.Dictionary<string, float>() {
    {"up", 9.94f},
    {"down", 0.12f}
  };

  void Start() {
    UnityEngine.GameObject cinematicModeObj = UnityEngine.GameObject.Find("CinematicMode");
    cinematicMode = cinematicModeObj.GetComponent<CinematicMode>();
    player = UnityEngine.GameObject.Find("ThirdPersonController");
  }

  System.Collections.IEnumerator MoveElevator(string direction) {
    float endY = elevatorPositions[direction];
    UnityEngine.Vector3 destination =  new UnityEngine.Vector3(transform.position.x, endY, transform.position.z);
    yield return new Vector3Transition(gameObject, destination, transitionDuration, easingFunction);
    if (direction == "down") {
      // Cinematic mode began while the elevator was going down. So we need to turn it off.
      cinematicMode.ExitCinematicMode();
      isLocatedUp = false;
    } else {
      isLocatedUp = true;
    }
  }

  System.Collections.IEnumerator MovePlayer(string direction) {
    float endY = elevatorPositions[direction];
    endY += playerHeightDiff;
    UnityEngine.Vector3 destination =  new UnityEngine.Vector3(player.transform.position.x, endY, player.transform.position.z);
    yield return new Vector3Transition(player, destination, transitionDuration, easingFunction);
  }

  void OnTriggerEnter(UnityEngine.Collider col) {
    if (!isLocatedUp) {
      return;
    }
    if (col.gameObject.name == "ThirdPersonController") {
      cinematicMode.EnterCinematicMode();
      StartCoroutine(MoveElevator("down"));
      StartCoroutine(MovePlayer("down"));
    }
  }

  // This is called by the child when the elevator has been exited
  // by the player.
  void ExitElevator() {
    if (isLocatedUp) {
      return;
    }
    StopCoroutine("MoveElevator");
    StartCoroutine(MoveElevator("up"));
  }
}
