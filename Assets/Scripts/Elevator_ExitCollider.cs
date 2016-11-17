public class Elevator_ExitCollider : UnityEngine.MonoBehaviour {
  void OnTriggerExit(UnityEngine.Collider col) {
    if (col.gameObject.name == "ThirdPersonController") {
      this.SendMessageUpwards("ExitElevator");
    }
  }
}
