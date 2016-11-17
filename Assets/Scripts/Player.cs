public class Player : UnityEngine.MonoBehaviour {
  public UnityEngine.Rigidbody rb;

	void Start() {
    rb = this.GetComponent<UnityEngine.Rigidbody>();
	}
	
	void Update() {
    this.CheckBounds();
  }

  void CheckBounds() {
    if (this.transform.position.y < -6) {
      rb.velocity = new UnityEngine.Vector3(0, 0, 0);
      this.transform.position = new UnityEngine.Vector3(0f, 17f, 0f);
    }
  }
}
