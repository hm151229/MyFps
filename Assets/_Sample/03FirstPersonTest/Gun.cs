using UnityEngine;
namespace MySample
{
    /// <summary>
    /// F키를 누르면 탄환 발사
    /// </summary>
    public class Gun : MonoBehaviour
    {
        #region Variavles
        public Transform firePoint;
        public GameObject bulletPrefab;

        #endregion

        #region Unity Event Method
        private void Update()
        {
            //F키를 누르면 탄환 발사
            if (Input.GetKeyDown(KeyCode.F))
            {
                Fire();
            }
        }
        #endregion

        #region Custom Method
        private void Fire()
        {
            GameObject bulletGo = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            Bullet bullet = bulletGo.GetComponent<Bullet>();
            if (bullet != null)
            {
                bullet.MoveForce();
            }

            //
            Destroy(bullet.gameObject, 3f);
        }

        
        #endregion

    }
}
