﻿using PelotonEppSdk.Interfaces;

namespace PelotonEppSdk.Models
{
    public class CreditCardResponse: Response, IVerificationResponse
    {
        /// <summary>
        /// The credit card token assigned to the newly created credit card
        /// </summary>
        public string CreditCardToken { get; set; }

        /// <summary>
        /// Result of the address verification process
        /// </summary>
        public string AddressVerificationResult { get; set; }

        /// <summary>
        /// Result of the card security code verification process
        /// </summary>
        public string CardSecurityCodeVerificationResult { get; set; }
    }

    // ReSharper disable InconsistentNaming
    internal class credit_card_response: response, Iverification_response
    {
        public string credit_card_token { get; set; }

        public string address_verification_result { get; set; }

        public string card_security_code_verification_result { get; set; }

        public static explicit operator CreditCardResponse(credit_card_response creditCardResponse)
        {
            if (creditCardResponse == null) return null;
            return new CreditCardResponse()
            {
                Success = creditCardResponse.success,
                Message = creditCardResponse.message,
                Errors = creditCardResponse.errors,
                MessageCode = creditCardResponse.message_code,
                CreditCardToken = creditCardResponse.credit_card_token,
                AddressVerificationResult = creditCardResponse.address_verification_result,
                CardSecurityCodeVerificationResult = creditCardResponse.card_security_code_verification_result
            };
        }
    }
}