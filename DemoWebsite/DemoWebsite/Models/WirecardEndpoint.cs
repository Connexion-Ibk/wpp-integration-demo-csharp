﻿// ***********************************************************************
// Assembly         : DemoWebsite
// Author           : r.wienicke
// Created          : 08-01-2019
//
// Last Modified By : r.wienicke
// Last Modified On : 08-05-2019
// ***********************************************************************
// <copyright file="WirecardEndpoint.cs" company="connexion e.solutions">
//     Copyright (c) connexion e.solutions. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoWebsite.Models
{
    /// <summary>
    /// the endpoint for the wirecard request
    /// </summary>
    public class WirecardEndpoint
    {
        /// <summary>
        /// name of the endpoint
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// uri at wirecard
        /// </summary>
        /// <value>The URI.</value>
        public Uri Uri { get; set; }
        /// <summary>
        /// the success redirect url
        /// can be set absolute or relative
        /// if relative the host is computed for the current application
        /// </summary>
        /// <value>The success redirect URL.</value>
        public Uri SuccessRedirectUrl { get; set; }
        /// <summary>
        /// the fail redirect url
        /// can be set absolute or relative
        /// if relative the host is computed for the current application
        /// </summary>
        /// <value>The fail redirect URL.</value>
        public Uri FailRedirectUrl { get; set; }
        /// <summary>
        /// the cancel redirect url
        /// can be set absolute or relative
        /// if relative the host is computed for the current application
        /// </summary>
        /// <value>The cancel redirect URL.</value>
        public Uri CancelRedirectUrl { get; set; }

        /// <summary>
        /// Gets the payment method.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>WirecardPayment.</returns>
        public WirecardPayment GetPaymentMethod(string name)
        {
            return PaymentMethods.FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// the payment methods
        /// </summary>
        /// <value>The payment methods.</value>
        public HashSet<WirecardPayment> PaymentMethods { get; set; }

        /// <summary>
        /// Gets or sets the ipn success notification URL.
        /// </summary>
        /// <value>The ipn success notification URL.</value>
        public string IpnSuccessNotificationUrl { get; set; }
        /// <summary>
        /// Gets or sets the ipn failed notification URL.
        /// </summary>
        /// <value>The ipn failed notification URL.</value>
        public string IpnFailedNotificationUrl { get; set; }
        /// <summary>
        /// Gets or sets the ipn default notification URL.
        /// </summary>
        /// <value>The ipn default notification URL.</value>
        public string IpnDefaultNotificationUrl { get; set; }
    }



}