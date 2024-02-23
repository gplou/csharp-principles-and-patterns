﻿using Decorator.Practice.Discounts.Problem.Service;
using Decorator.Practice.Discounts.Shared;
using Decorator.Practice.Discounts.Shared.Models;

var discountService = new DiscountService();

const string defaultCurrencyCode = "EUR";

var simplePrice = new PriceType
{
    BaseAmount = new AmountType
    {
        CurCode = defaultCurrencyCode,
        Value = 100
    },
    TotalAmount = new AmountType
    {
        CurCode = defaultCurrencyCode,
        Value = 100
    }
};

Console.WriteLine("Simple price:");
SharedUtils.WritePrice(simplePrice);

var discounts = new List<string> { "RESIDENT", "FN1", "FN2", "RFN1", "RFN2" };

foreach (var discount in discounts)
{
    Console.WriteLine($"{discount} discount:");
    var discountedPrice = discountService.GetDiscountedPrice(simplePrice, discount);
    SharedUtils.WritePrice(discountedPrice);
}
