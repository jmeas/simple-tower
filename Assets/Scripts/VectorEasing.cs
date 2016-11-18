using UnityEngine;

// Use these just like `UnityEngine.Vector3.Lerp`.
// They're non-linear easing functions.

public class VectorEasing {
  public static Vector3 Lerp(Vector3 a, Vector3 b, float t) {
    t = Mathf.Clamp01(t);
    return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
  }

  public class Quadratic {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = Easing.Quadratic.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = Easing.Quadratic.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = Easing.Quadratic.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Cubic {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = Easing.Cubic.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = Easing.Cubic.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = Easing.Cubic.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Quartic {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = Easing.Quartic.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = Easing.Quartic.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = Easing.Quartic.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }
}
