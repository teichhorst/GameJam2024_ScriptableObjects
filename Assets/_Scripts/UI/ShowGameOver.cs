using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _Scripts.UI
{
    public class ShowGameOver : MonoBehaviour
    {
        public Transform gameOverText;
        public Image gameOverBackground;

        public void StartGameOverSequence()
        {
            StartCoroutine(AnimateGameOver());
        }

        private void Awake()
        {
            gameOverText.localScale = Vector3.zero;
            gameOverBackground.color = Color.clear;
        }

        private IEnumerator AnimateGameOver()
        {
            float timer = 2f;
            
            while (timer > 0)
            {
                timer -= Time.deltaTime;
                gameOverText.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, timer / 2f);
                gameOverBackground.color = Color.Lerp(Color.black, Color.clear, timer / 2f);
                yield return null;
            }

            yield return new WaitForSeconds(3f);

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}