using UnityEngine;
using System.Collections;

namespace CubeSpace
{
    // Destroy object after lifetime has passed.
    public class DestroyByTime : MonoBehaviour
    {

        public float lifetime;
        
        void Start()
        {
            // Self destruct after "lifetime"
            Destroy(gameObject, lifetime);
        }

        void Update()
        {

        }
    }
}