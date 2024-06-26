﻿using System.ComponentModel.DataAnnotations;
using Bit.Api.Utilities;
using Bit.Core.Enums;

namespace Bit.Api.Billing.Models.Requests;

public class TokenizedPaymentMethodRequestBody
{
    [Required]
    [EnumMatches<PaymentMethodType>(
        PaymentMethodType.BankAccount,
        PaymentMethodType.Card,
        PaymentMethodType.PayPal,
        ErrorMessage = "'type' must be BankAccount, Card or PayPal")]
    public PaymentMethodType Type { get; set; }
    [Required]
    public string Token { get; set; }
}
