using System;
using JetBrains.Annotations;
using UnityEngine;
using Voodoo.Sauce.IAP;

namespace EasyGame.Iap
{
	public class EasyVoodooIap : MonoBehaviour, IEasyStoreCustom, IPurchaseDelegateWithInfo, IPurchaseDelegateBase
	{
		private readonly string LogTag;

		private bool m_Ready;

		private string m_CurReceipt;

		private string m_TransactionID;

		private Action<bool> m_PurchaseResAc;

		public void Init()
		{
		}

		private void OnInitialized()
		{
		}

		public void OnInitializeSuccess()
		{
		}

		public void OnInitializeFailure(VoodooInitializationFailureReason reason)
		{
		}

		public bool IsPurchased(string pStoreId)
		{
			return false;
		}

		public void PurchaseProduct(string pStoreId, Action<bool> pResAc)
		{
		}

		public bool OnPurchaseComplete(ProductReceivedInfo productReceivedInfo, PurchaseValidation purchaseValidation)
		{
			return false;
		}

		public void OnPurchaseFailure(VoodooPurchaseFailureReason reason, [CanBeNull] ProductReceivedInfo productReceivedInfo, string description)
		{
		}

		public void RestorePurchase(Action<bool, string> pEndAc)
		{
		}

		private ProductReceivedInfo GetProduct(string pStoreId)
		{
			return null;
		}

		public string GetISOCurrencySymbol(string pStoreId)
		{
			return null;
		}

		public string GetLocalizedPrice(string pStoreId)
		{
			return null;
		}

		public double GetPriceInLocalCurrency(string pStoreId)
		{
			return 0.0;
		}

		public string CurReceipt()
		{
			return null;
		}

		public string CurTransactionID()
		{
			return null;
		}
	}
}
