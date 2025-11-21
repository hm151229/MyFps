using UnityEngine;

namespace MyFps
{
    /// <summary>
    /// 플레이어와 인터렉션 기능 오브젝트
    /// 인터렉티브 : 마우스를 가져가면 UI활성화 빼면 비활성화
    /// 인터렉션 기능 : 도어 오픈
    /// </summary>
    public class DoorCellOpen : Interactive
    {
        #region Variables
        [Header("Interactive Action")]
        //액션
        public Animator animator;
        public AudioSource audioSource;

        //애니메이션 파라미터
        private string Open = "Open";
        #endregion

        #region Custom Method
        protected override void DoAction()
        {
            //UI
            HideActionUI();

            //애니메이션
            animator.SetTrigger(Open);

            //사운드 플레이
            if (audioSource)
            {
                audioSource.Play();
            }
        }
        #endregion
    }
}