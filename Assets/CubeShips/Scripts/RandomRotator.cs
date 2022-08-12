using UnityEngine;
using System.Collections;

namespace CubeSpace
{
    // Rotates an object randomly
    public class RandomRotator : MonoBehaviour
    {
        public float tumble;

        // Use this for initialization
        void Start()
        {
            GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
        }
    }
}
