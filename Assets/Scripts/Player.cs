using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _foodColl;
    [SerializeField] private TMP_Text _textCollFood;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private GameObject _foodObject;
    [SerializeField] private FoodSpawn foodSpawn;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Food"))
        {
            _foodColl += 1;
            foodSpawn.i--;
        }
    }

    private void Update()
    {
        if(Input.GetButton("Horizontal")) Move();
    }
    private void FixedUpdate()
    {
        _textCollFood.text =  "Колличество еды: "+ _foodColl;
    }

    private void Move()
    {
        float _x = Input.GetAxis("Horizontal");
        Vector3 _move = new Vector3(_x * _speed, 0f, 0f);
        _rb.velocity = _move;
    }
}
