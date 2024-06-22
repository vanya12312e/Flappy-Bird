using UnityEngine;
using System.Collections;
public class PipeGanerator : MonoBehaviour
{
    [SerializeField] private GameObject _pipe;

    private void Start()
    {
        StartCoroutine(PipeSpawner());
    }

   IEnumerator PipeSpawner()
   {
        while(true)
        {
            Vector2 _spawnPosition = new Vector2(4, Random.Range(-4, 4));
            Instantiate(_pipe, _spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
   }
}

