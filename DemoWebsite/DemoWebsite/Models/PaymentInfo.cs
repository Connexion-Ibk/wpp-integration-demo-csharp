﻿// ***********************************************************************
// Assembly         : DemoWebsite
// Author           : r.wienicke
// Created          : 08-01-2019
//
// Last Modified By : r.wienicke
// Last Modified On : 08-02-2019
// ***********************************************************************
// <copyright file="PaymentInfo.cs" company="connexion e.solutions">
//     Copyright (c) connexion e.solutions. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace DemoWebsite.Models
{
    /// <summary>
    /// the payment info
    /// </summary>
    public class PaymentInfo
    {
        /// <summary>
        /// the request id
        /// must be unique for each call
        /// </summary>
        /// <value>The request identifier.</value>
        public string RequestId { get; internal set; }

        /// <summary>
        /// the requseted amount
        /// </summary>
        /// <value>The requested amount.</value>
        public RequestedAmount RequestedAmount { get; set; }

        /// <summary>
        /// the card holder
        /// </summary>
        /// <value>The account holder.</value>
        public AccountHolder AccountHolder { get; set; }

        /// <summary>
        /// the card holder
        /// </summary>
        /// <value>The shipping.</value>
        public Shipping Shipping { get; set; }


        /// <summary>
        /// the paymentname from config settings
        /// </summary>
        /// <value>The name of the payment.</value>
        public string PaymentName { get; set; }
        /// <summary>
        /// the endpointname from config settings
        /// </summary>
        /// <value>The name of the endpoint.</value>
        public string EndpointName { get; set; }

        /// <summary>
        /// the transaction type
        /// </summary>
        /// <value>The type of the transaction.</value>
        public TransactionType? TransactionType { get; set; }


    }


}
