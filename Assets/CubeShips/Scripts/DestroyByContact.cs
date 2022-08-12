using UnityEngine;
using System.Collections;

namespace CubeSpace
{
    public class DestroyByContact : MonoBehaviour
    {
        public GameObject explosion;
        public GameObject playerExplosion;
        public int scoreValue;
        private static GameController gameController;
        private bool isVisible = false;

        // Use this for initialization
        void Start()
        {
            if (!gameController)
                gameController = GameObject.FindObjectOfType<GameController>();
        }

        void OnBecameInvisible()
        {
            isVisible = false;
        }

        void OnBecameVisible()
        {
            isVisible = true;
        }

        void OnTriggerEnter(Collider other)
        {
            // Ignore bullet to bullet collision.  Note: you can optimize these by using Tags
            if (this.GetComponent<Bullet>() && other.GetComponent<Bullet>())
                return;

            // ignore collision with Enemy or Boundary
            if (other.name=="Boundary")
                return;
            if (other.GetComponent<Enemy>() && this.GetComponent<EnemyBullet>())
                return;
            if (other.GetComponent<EnemyBullet>() && this.GetComponent<Enemy>())
                return;

            // Launch explosion effect
            if (explosion)
                Instantiate(explosion, transform.position, transform.rotation);

            // If player is hit, Game Over
            if (other.CompareTag("Player"))
            {
                Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
                gameController.GameOver();
            }
            gameController.AddScore(scoreValue);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
