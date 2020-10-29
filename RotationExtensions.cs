using UnityEngine;

public static class RotationExtensions
{
    public static Quaternion ClampRotationAroundXAxis(this Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        q.y = 0f;
        q.z = 0f;

        return q;
    }
    public static Quaternion ClampRotationAroundYAxis(this Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        q.x = 0f;
        q.z = 0f;

        return q;
    }
    public static Quaternion ClampRotationAroundZAxis(this Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        q.x = 0f;
        q.y = 0f;

        return q;
    }

    public static Quaternion ClampRotationXAxis(this Quaternion q, float min, float max)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        float angle = 2f * Mathf.Rad2Deg * Mathf.Atan(q.x);

        angle = Mathf.Clamp(angle, min, max);

        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angle);

        return q;
    }
    public static Quaternion ClampRotationYAxis(this Quaternion q, float min, float max)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        float angle = 2f * Mathf.Rad2Deg * Mathf.Atan(q.y);

        angle = Mathf.Clamp(angle, min, max);

        q.y = Mathf.Tan(0.5f * Mathf.Deg2Rad * angle);

        return q;
    }
    public static Quaternion ClampRotationZAxis(this Quaternion q, float min, float max)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        float angle = 2f * Mathf.Rad2Deg * Mathf.Atan(q.z);

        angle = Mathf.Clamp(angle, min, max);

        q.z = Mathf.Tan(0.5f * Mathf.Deg2Rad * angle);

        return q;
    }
}
