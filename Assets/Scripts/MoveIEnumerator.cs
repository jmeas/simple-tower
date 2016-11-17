public class MoveIEnumerator : System.Collections.IEnumerator {
  UnityEngine.GameObject target;
  float destination;
  float speed;

  public MoveIEnumerator(UnityEngine.GameObject obj, float dest, float velocity) {
    target = obj;
    destination = dest;
    speed = velocity;
  }

  public bool MoveNext() {
    UnityEngine.Vector3 curPos = this.target.transform.position;
    float currentY = curPos.y;

    bool transitionComplete = currentY == destination;
    if (!transitionComplete) {
      UnityEngine.Vector3 updatedPos = new UnityEngine.Vector3 (curPos.x, UnityEngine.Mathf.MoveTowards(currentY, destination, speed * UnityEngine.Time.deltaTime), curPos.z);
      this.target.transform.position = updatedPos;
    }

    return !transitionComplete;
  }

  // Intentionally blank
  public void Reset() {}

  // Intentionally null
  object System.Collections.IEnumerator.Current {
    get {
      return null;
    }
  }
}