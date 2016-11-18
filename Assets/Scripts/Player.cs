public class Player : UnityEngine.MonoBehaviour {
  public UnityEngine.Rigidbody rb;
  UnityEngine.Vector3 startPosition = new UnityEngine.Vector3(0f, 17f, 0f);
  UnityEngine.Vector3 stationary = UnityEngine.Vector3.zero;

  void Start() {
    rb = GetComponent<UnityEngine.Rigidbody>();
    InvokeRepeating("CheckOutOfBounds", 0f, 0.1f);
  }

  public void CheckOutOfBounds() {
    if (transform.position.y < -6) {
      // Reset the player's velocity and their position
      rb.velocity = stationary;
      transform.position = startPosition;
    }
  }
}
