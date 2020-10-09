using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace QG.InventorySystem {
    /// <summary>
    /// Класс ссылка, в этом объекте происходит детальный обзор айтема.
    /// </summary>
    public class ModelView : MonoBehaviour {
        public static ModelView _instance { get; private set; }

        [SerializeField] BlankOverlay blank;
        [SerializeField] ViewBookUI viewBook;
        [SerializeField] ViewItemUI viewItem;

        [HideInInspector] public ItemViewModel sender;

        public static void Init() {
            if (_instance == null)
                _instance = FindObjectOfType<ModelView>();
        }
        private void Awake() {
            if (_instance == null)
                _instance = this;
        }

        public void SetItem(ItemViewModel newSender) {
            sender = newSender;
            ReloadView();
            EnableOverlay(true);
        }
        public void ReloadView() {
            if (sender == null) return;

            if(sender.item is ItemBook)
                viewBook.SetSprite(sender.item.itemIcon).ActiveView(true);
            else 
                viewItem.SetSprite(sender.item.itemIcon).ActiveView(true);

        }
        public void EnableOverlay(bool triger) {
            blank.EnableView(triger);
        }
    }
}