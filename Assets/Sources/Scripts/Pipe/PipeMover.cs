using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if(transform.position.x <= -7)
        {
            Destroy(gameObject);
        }
    }
}
