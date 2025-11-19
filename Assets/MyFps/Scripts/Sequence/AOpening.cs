using System.Collections;
using TMPro;
using UnityEngine;

namespace MyFps
{
    /// <summary>
    /// 플레이씬의 오프닝 연출 
    /// </summary>
    public class AOpening : MonoBehaviour
    {
        #region Variables
        public SceneFader fader;
        public TextMeshProUGUI sequenceText;
        public GameObject player;
        

        //시나리오 대사
        [SerializeField]
        private string sequence01 = "I need get out of here";
        
        #endregion

        #region Unity Event Method
        void Start()
        {
            StartCoroutine(SequencePlay());
        }
        #endregion

        #region Custom Method
        //오프닝 시퀀스 연출
        IEnumerator SequencePlay ()
        {
            player.SetActive(false);

            fader.FadeStart(1f);

            sequenceText.text = sequence01;
            yield return new WaitForSeconds(3f);
            //대사 초기화
            sequenceText.text = "";
            player.SetActive(true);
            
        }
        #endregion
    }
}
