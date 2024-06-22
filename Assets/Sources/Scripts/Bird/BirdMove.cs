using UnityEngine.SceneManagement;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]
[RequireComponent(typeof (CircleCollider2D))]

public class BirdMove : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Quaternion _maxRotation; 
    private Quaternion _minRotation;

    [Header("RotationFields")]

    [SerializeField] private float _maxRotationZ;
    [SerializeField]private float _minRotationZ;

    [Header("JumpField")]
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _tapForce;

    [Header("UI")]
    private UImanager _uiManager;
    [SerializeField] private GameObject _panel;




    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _uiManager = FindObjectOfType<UImanager>();

        _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);
        _minRotation = Quaternion.Euler(0, 0, _minRotationZ);

        _uiManager = new UImanager();
        _uiManager.StartButton();



    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _rigidbody2D.velocity = new Vector2(transform.position.x, _tapForce);
            transform.rotation = _maxRotation;
        }

        
        transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, _rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Pipe")
        {
            /*_uiManager.Show(_panel);
             Time.timeScale = 0;*/

            SceneManager.LoadScene(0);
           
        }
      
    }


}
