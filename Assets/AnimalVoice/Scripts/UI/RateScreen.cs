using BabySound.Scripts;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace AnimalVoice.Scripts.UI
{
    public class RateScreen : AppPopup
    {
        [SerializeField] private Button _rateButton;

        public override void OnOpen()
        {
            transform.DOKill();
            transform.GetComponent<RectTransform>().DOAnchorPosY(-1000, 0).OnComplete(() =>
            {
                transform.GetComponent<RectTransform>().DOAnchorPosY(0, 0.5f);
            });
        }

        protected override void Start()
        {
            base.Start();
            _rateButton.onClick.AddListener(RateGame);
        }

        public void RateGame()
        {
            GameDataManager.Instance.playerData.Rated();
        }
    }
}