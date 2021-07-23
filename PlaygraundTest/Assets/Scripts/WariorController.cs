using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Game
{

    public class WariorController : MonoBehaviour
    {
        [SerializeField] private GameController gameContrl;
        [SerializeField] private int maxHealth = 3;
        [SerializeField] private Healtbar healthbar;
        [SerializeField] private TextMeshProUGUI indicator;
        [SerializeField] private CharacterController controller;
        [SerializeField] private float speed;

        public int currentHealth;
        
        private Vector3 movement;
        private Animator anim;
        private Rigidbody playerRigidbody;
        private int floorMask;
        private float camRayLength = 100f;
        private int score = 0;

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

        #region Move&Mouse
        public void Speed(float speeds)
        {
            speed = speeds + 6f;
        }
        public void Move(float h, float v)
        {
            movement.Set(h, 0f, v);
            movement = movement.normalized * speed * Time.deltaTime;
            playerRigidbody.MovePosition(transform.position + movement);
        }
        void Animating(float h, float v)
        {
            bool walking = h != 0f || v != 0f;
            anim.SetBool("isWalking", walking);
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
        #endregion

        #region Collision
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
            if (PlayerCol.gameObject.tag == "Bonus")
            {
                Destroy(PlayerCol.gameObject, 0f);
                gameContrl.Bonus();
            }
        }
        void TakeDamage(int damage)
        {
            currentHealth -= damage;
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

        public void ScoreCoin(int takecoin)
        {
            score += takecoin;
            indicator.text = score.ToString();
        }
        #endregion
    }
}
