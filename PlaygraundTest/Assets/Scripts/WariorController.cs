using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Game
{

    public class WariorController : MonoBehaviour
    {
        [SerializeField] private int maxHealth = 3;
        public int currentHealth;
        [SerializeField] private Healtbar healthbar;
        private int score = 0;
        [SerializeField] private TextMeshProUGUI indicator;
        //
        [SerializeField] private CharacterController controller;
        [SerializeField] private float speed = 6f;

        Vector3 movement;
        Animator anim;
        Rigidbody playerRigidbody;
        int floorMask;
        float camRayLength = 100f;
        private void OnCollisionEnter(Collision PlayerCol)
        {
            if (PlayerCol.gameObject.tag == "Enemy")
            {
                Debug.Log("Получил урон");
                TakeDamage(1);
                
            }
            if (PlayerCol.gameObject.tag == "CoinTag")
            {
                Destroy(PlayerCol.gameObject, 0f);
                ScoreCoin(1);
            }
        }
        public void ScoreCoin(int takecoin)
        {
            score += takecoin;
            indicator.text = score.ToString();
        }
        void TakeDamage(int damage)
        {
            
            currentHealth -= damage ;
            healthbar.SetHealth(currentHealth);
            if (currentHealth == 0)
            {
                Dead();
            }
        }
        public void Dead()
        {
            Debug.LogError("Вы умерли");
            Destroy(gameObject, 0f);
        }
        void Awake()
        {
            floorMask = LayerMask.GetMask("Ground");

            anim = GetComponent<Animator>();
            playerRigidbody = GetComponent<Rigidbody>();
        }
        void Start()
        {
            indicator.text = score.ToString();
            currentHealth = maxHealth;
            healthbar.SetMaxHealth(maxHealth);

        }
        void FixedUpdate()
        {
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");

            Move(h, v);

            Turning();

            Animating(h, v);
        }
        void Move(float h, float v)
        {
            movement.Set(h, 0f, v);

            movement = movement.normalized * speed * Time.deltaTime;

            playerRigidbody.MovePosition(transform.position + movement);
        }
        void Turning()
        {
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit floorHit;

            if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
            {
                Vector3 playerToMouse = floorHit.point - transform.position;

                playerToMouse.y = 0f;

                Quaternion newRotation = Quaternion.LookRotation(playerToMouse);

                playerRigidbody.MoveRotation(newRotation);
            }
        }
        void Animating(float h, float v)
        {
            bool walking = h != 0f || v != 0f;

            anim.SetBool("isWalking", walking);
        }
    }
}
