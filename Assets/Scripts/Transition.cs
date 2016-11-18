using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Transition : IEnumerator {
  // The GameObject being moved
  GameObject target;

  // The initial position of that game object
  Vector3 initial;

  // The Vector3 end destination
  Vector3 destination;

  // How long the animation should last
  float duration;

  // How far this animation has progressed. Goes between 0 and 1.
  float progress = 0;

  // How much time has passed in this animation
  float totalTime = 0;

  // The value of Time.time for the previous frame of this animation
  float lastTime;

  Func<Vector3, Vector3, float, Vector3> easing;

  // These are the options for easing functions. They map to functions in VectorEasing.cs
  Dictionary<string, Func<Vector3, Vector3, float, Vector3>> easingFunctions =
    new Dictionary<string, Func<Vector3, Vector3, float, Vector3>> {
      { "Linear", VectorEasing.Lerp },
      { "QuadraticIn", VectorEasing.Quadratic.In },
      { "QuadraticOut", VectorEasing.Quadratic.Out },
      { "QuadraticInOut", VectorEasing.Quadratic.InOut }
    };

  public Transition(GameObject obj, Vector3 dest, float time, string easingFunction = "Linear") {
    target = obj;
    initial = obj.transform.position;
    duration = time;
    destination = dest;
    easing = easingFunctions[easingFunction];
  
    // We set the "last time" to be the current time, as this is the start of the animation.
    lastTime = Time.time;
  }

  public bool MoveNext() {
    // The current progress is how much time has passed divided by the duration, which is the
    // total time. This should be roughly between 0 and 1.
    progress = totalTime / duration;

    // We use our easing function to find the current position
    target.transform.position = easing(initial, destination, progress);

    // Update the total time with however much time has passed since our lastTime.
    totalTime += Time.time - lastTime;

    lastTime = Time.time;
    return progress < 1;
  }

  // Intentionally blank
  public void Reset() {}

  // Intentionally null
  object IEnumerator.Current {
    get {
      return null;
    }
  }
}