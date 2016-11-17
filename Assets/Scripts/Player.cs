﻿public class Player : UnityEngine.MonoBehaviour {
  public UnityEngine.Rigidbody rb;
  UnityEngine.Vector3 startPosition = new UnityEngine.Vector3(0f, 17f, 0f);
  UnityEngine.Vector3 stationary = new UnityEngine.Vector3(0, 0, 0);

  void Start() {
    rb = this.GetComponent<UnityEngine.Rigidbody>();
    StartCoroutine(CheckOutOfBounds());
  }

  public System.Collections.IEnumerator CheckOutOfBounds() {
    // This checks the boundaries always. Eventually, we'll want to turn this off
    // under certain conditions, like when the player doesn't have control over
    // the player's movement.
    while(true) {
      if (this.transform.position.y < -6) {
        // Reset the player's velocity and their position
        rb.velocity = stationary;
        this.transform.position = startPosition;
      }

      // The player bounds are pretty loosely defined, so it's fine to check on
      // them a little less frequently.
      yield return new UnityEngine.WaitForSeconds(0.1f);
    }
  }
}
