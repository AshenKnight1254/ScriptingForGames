using UnityEngine;

public class BounceyBall : MonoBehaviour
{
    public float bouceForce = 3F;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bouceForce, ForceMode.Impulse);
    }
}
