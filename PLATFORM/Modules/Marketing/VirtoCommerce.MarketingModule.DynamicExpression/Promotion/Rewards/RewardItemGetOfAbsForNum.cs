﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtoCommerce.Domain.Marketing.Model;

namespace VirtoCommerce.MarketingModule.Expressions.Promotion
{
	//Get $[] off [] items
	public class RewardItemGetOfAbsForNum : DynamicExpression, IRewardExpression
	{
		public decimal Amount { get; set; }
		public string ProductId { get; set; }
		public int NumItem { get; set; }

		#region IRewardExpression Members

		public PromotionReward[] GetRewards()
		{
			var retVal = new CatalogItemAmountReward
			{
				Amount = Amount,
				AmountType = RewardAmountType.Absolute,
				Quantity = NumItem,
				ProductId = ProductId
			};
			return new PromotionReward[] { retVal };
		}

		#endregion
	}
}
