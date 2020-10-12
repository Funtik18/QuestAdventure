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
        [SerializeField] ViewPickUpUI viewPick;

        [HideInInspector] public ItemModel sender;

        public static void Init() {
            if (_instance == null)
                _instance = FindObjectOfType<ModelView>();
        }
        private void Awake() {
            if (_instance == null)
                _instance = this;
        }
        /// <summary>
        /// Меняет айтем для осмотра.
        /// </summary>
        /// <param name="sender"></param>
        public void SetModel(ItemModel sender) {
            this.sender = sender;
            EnableOverlay(true);
            if (this.sender != null) {
                if(this.sender is ItemBookModel bookModel) {
                    viewBook.SetBook(bookModel.item).ActiveView(true);
                }
                else if (this.sender is ItemPickModel pickModel) {
                    viewPick.SetSprite(pickModel.item).ActiveView(true);
                }
            }
        }
        public void EnableOverlay(bool triger) {
            blank.EnableView(triger);
        }
    }
}