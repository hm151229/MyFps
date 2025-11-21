using UnityEngine;
using MyFps;

namespace MySample2
{
    public class Goblin : MonoBehaviour, IDamageable
    {
        //체력
        private float health;
        [SerializeField]
        private float maxHealth = 20f;
        //죽음 체크
        private bool isDeath = false;

        private void Start()
        {
            //초기화
            health = maxHealth;
        }

        //데미지 주기
        public void TakeDamage(float damage)
        {
            health -= damage;
            Debug.Log(health);

            //죽음 체크
            if (health <= 0f && isDeath == false)
            {
                Die();
            }
        }
        //죽음 처리
        void Die()
        {
            isDeath = true;
        }
    }
}
