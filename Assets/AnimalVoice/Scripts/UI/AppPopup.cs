﻿using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace BabySound.Scripts
{
    public class AppPopup : BasePopup
    {
        [SerializeField] private Button _closeBtn;

        public override void OnOpen()
        {
            base.OnOpen();
            transform.DOKill();
            transform.localScale = Vector3.one * 0.5f;
            transform.DOScale(Vector3.one, 0.2f);
        }

        private void Start()
        {
            _closeBtn?.onClick.AddListener(Back);
        }
    }
}