public class MoveIEnumerator : System.Collections.IEnumerator {
  // The GameObject being moved
  UnityEngine.GameObject target;

  // The initial position of that game object
  UnityEngine.Vector3 initial;

  // The Vector3 end destination
  UnityEngine.Vector3 destination;

  // How long the animation should last
  float duration;

  // How far this animation has progressed. Goes between 0 and 1.
  float progress = 0;

  // How much time has passed in this animation
  float totalTime = 0;

  // The value of UnityEngine.Time.time for the previous frame of this animation
  float lastTime;

  public MoveIEnumerator(UnityEngine.GameObject obj, float finalY, float time) {
    target = obj;
    initial = obj.transform.position;
    duration = time;

    // Create our destination. Right now, this IEnumerator only allows vertical movement.
    destination = new UnityEngine.Vector3(target.transform.position.x, finalY, target.transform.position.z);

    // We set the "last time" to be the current time, as this is the start of the animation.
    lastTime = UnityEngine.Time.time;
  }

  public bool MoveNext() {
    // The current progress is how much time has passed divided by the duration, which is the
    // total time. This should be roughly between 0 and 1.
    progress = totalTime / duration;

    // We use our transform function to find the new position. Because it uses progress, we can
    // swap "Lerp" for any easing function that we'd like.
    target.transform.position = UnityEngine.Vector3.Lerp(initial, destination, progress);

    // Update the total time with however much time has passed since our lastTime.
    totalTime += UnityEngine.Time.time - lastTime;

    lastTime = UnityEngine.Time.time;
    return progress < 1;
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