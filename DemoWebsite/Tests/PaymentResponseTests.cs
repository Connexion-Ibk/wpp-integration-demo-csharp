// Copyright (c) 2019 connexion OG / Roman Wienicke

using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Wirecard.Models;

namespace Tests
{
    public class Tests
    {
      

        /// <summary>
        /// simple tests for parsing of the result json
        /// </summary>
        /// <param name="responseFile"></param>
        /// <param name="type"></param>
        ///  xmlns="http://www.elastic-payments.com/schema/payment"
        //[TestCase("paymentResponse_cc.json", "creditcard", RequestFormat.Json)]
        //[TestCase("paymentResponse_eps.json", "eps")]
        //[TestCase("paymentResponse_klarna.json", "sofortbanking", RequestFormat.Json)]
        //[TestCase("paymentResponse_paypal.json", "paypal", RequestFormat.Json)]
        //[TestCase("paymentResponse_klarna.xml", "sofortbanking", RequestFormat.Xml)]
        [TestCase("paymentResponse_google_error.xml", "google", RequestFormat.Xml)]
        public void ParsePaymentResponseTest(string responseFile, string payment, RequestFormat type)
        {
            string content = GetFileInStartupPath(responseFile);
            var result = PaymentResponse.Parse(content, type);
            //Assert.IsTrue(result.Payment.PaymentMethods.PaymentMethod.FirstOrDefault().Name == payment);
        }

        private static string GetFileInStartupPath(string responseFile)
        {
            var fileName = Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), responseFile);
            var content = File.ReadAllText(fileName);
            return content;
        }

        [TestCase("IpnResponse.json", "sofortbanking", RequestFormat.Json)]
        public void ParsePaymentIpnResponseTest(string responseFile, string payment, RequestFormat type)
        {
            string content = GetFileInStartupPath(responseFile);
            var result = PaymentResponse.Parse(content, type);
        }

        [TestCase(1564992944000)]
        public void TimeStampConvertionTest(long timestamp)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(timestamp);
            var date = dateTimeOffset.UtcDateTime.ToLocalTime();
            
        }

        [TestCase]
        public void XmlResponseFailedTest() {
            var xml = @"<payment xmlns=""http://www.elastic-payments.com/schema/payment"">
              <transaction-state>failed</transaction-state>
              <statuses>
                <status code=""400.1031"" description=""Possible malformed request. Please check your input"" severity=""error"" />
              </statuses>
            </payment>
            ";

          

        }
    }
}