/*
 * Calc.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using Calc.PCL.Controllers;
using Calc.PCL.Http.Client;

namespace Calc.PCL
{
    public partial class CalcClient
    {

        /// <summary>
        /// Singleton access to SimpleCalculator controller
        /// </summary>
        public SimpleCalculatorController SimpleCalculator
        {
            get
            {
                return SimpleCalculatorController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public CalcClient() { }
    }
}