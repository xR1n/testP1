using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{

    // �ړ�
    public float moveSpeed; // �ړ����x
    private float horizontal; // x
    private float vertical; // y

    private Rigidbody2D rb;

    // �A�j���[�V����
    [SerializeField]
    private Animator animatior;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
