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

  public class Quintic {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = Easing.Quintic.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = Easing.Quintic.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = Easing.Quintic.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Sinusoidal {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = Easing.Sinusoidal.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = Easing.Sinusoidal.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = Easing.Sinusoidal.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Exponential {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = Easing.Exponential.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = Easing.Exponential.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = Easing.Exponential.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Circular {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = Easing.Circular.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = Easing.Circular.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = Easing.Circular.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Elastic {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = Easing.Elastic.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = Easing.Elastic.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = Easing.Elastic.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Back {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = Easing.Back.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = Easing.Back.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = Easing.Back.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Bounce {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = Easing.Bounce.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = Easing.Bounce.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = Easing.Bounce.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }
}
