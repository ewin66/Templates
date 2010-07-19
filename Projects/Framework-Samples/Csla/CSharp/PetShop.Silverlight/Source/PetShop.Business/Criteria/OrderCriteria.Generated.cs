﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1825, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Order.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Csla.Core;
#if SILVERLIGHT
using Csla.Serialization;
#endif
using Csla.Serialization.Mobile;

#if !SILVERLIGHT
using System.Data.SqlClient;
#endif

using Csla;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class OrderCriteria : CriteriaBase<OrderCriteria>, IGeneratedCriteria
    {
        #region Private Read-Only Members
        
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #endregion
        
        #region Constructors

        public OrderCriteria(){}

        public OrderCriteria(System.Int32 orderId)
        {
            OrderId = orderId;
        }
        
        #endregion
        
        #region Public Properties
        
        #region Read-Write

        public System.Int32 OrderId
        {
            get { return GetValue< System.Int32 >("OrderId"); }
            set { _bag["OrderId"] = value; }
        }

        public System.String UserId
        {
            get { return GetValue< System.String >("UserId"); }
            set { _bag["UserId"] = value; }
        }

        public System.DateTime OrderDate
        {
            get { return GetValue< System.DateTime >("OrderDate"); }
            set { _bag["OrderDate"] = value; }
        }

        public System.String ShipAddr1
        {
            get { return GetValue< System.String >("ShipAddr1"); }
            set { _bag["ShipAddr1"] = value; }
        }

        public System.String ShipAddr2
        {
            get { return GetValue< System.String >("ShipAddr2"); }
            set { _bag["ShipAddr2"] = value; }
        }

        public System.String ShipCity
        {
            get { return GetValue< System.String >("ShipCity"); }
            set { _bag["ShipCity"] = value; }
        }

        public System.String ShipState
        {
            get { return GetValue< System.String >("ShipState"); }
            set { _bag["ShipState"] = value; }
        }

        public System.String ShipZip
        {
            get { return GetValue< System.String >("ShipZip"); }
            set { _bag["ShipZip"] = value; }
        }

        public System.String ShipCountry
        {
            get { return GetValue< System.String >("ShipCountry"); }
            set { _bag["ShipCountry"] = value; }
        }

        public System.String BillAddr1
        {
            get { return GetValue< System.String >("BillAddr1"); }
            set { _bag["BillAddr1"] = value; }
        }

        public System.String BillAddr2
        {
            get { return GetValue< System.String >("BillAddr2"); }
            set { _bag["BillAddr2"] = value; }
        }

        public System.String BillCity
        {
            get { return GetValue< System.String >("BillCity"); }
            set { _bag["BillCity"] = value; }
        }

        public System.String BillState
        {
            get { return GetValue< System.String >("BillState"); }
            set { _bag["BillState"] = value; }
        }

        public System.String BillZip
        {
            get { return GetValue< System.String >("BillZip"); }
            set { _bag["BillZip"] = value; }
        }

        public System.String BillCountry
        {
            get { return GetValue< System.String >("BillCountry"); }
            set { _bag["BillCountry"] = value; }
        }

        public System.String Courier
        {
            get { return GetValue< System.String >("Courier"); }
            set { _bag["Courier"] = value; }
        }

        public System.Decimal TotalPrice
        {
            get { return GetValue< System.Decimal >("TotalPrice"); }
            set { _bag["TotalPrice"] = value; }
        }

        public System.String BillToFirstName
        {
            get { return GetValue< System.String >("BillToFirstName"); }
            set { _bag["BillToFirstName"] = value; }
        }

        public System.String BillToLastName
        {
            get { return GetValue< System.String >("BillToLastName"); }
            set { _bag["BillToLastName"] = value; }
        }

        public System.String ShipToFirstName
        {
            get { return GetValue< System.String >("ShipToFirstName"); }
            set { _bag["ShipToFirstName"] = value; }
        }

        public System.String ShipToLastName
        {
            get { return GetValue< System.String >("ShipToLastName"); }
            set { _bag["ShipToLastName"] = value; }
        }

        public System.Int32 AuthorizationNumber
        {
            get { return GetValue< System.Int32 >("AuthorizationNumber"); }
            set { _bag["AuthorizationNumber"] = value; }
        }

        public System.String Locale
        {
            get { return GetValue< System.String >("Locale"); }
            set { _bag["Locale"] = value; }
        }

        #endregion
        
        #region Read-Only

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public Dictionary<string, object> StateBag
        {
            get
            {
                return _bag;
            }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public string TableFullName
        {
            get
            {
                return "[dbo].Orders";
            }
        }

        #endregion

        #endregion

        #region Overrides
        
        public override string ToString()
        {
            var result = string.Empty;
            var cancel = false;
            
            OnToString(ref result, ref cancel);
            if(cancel && !string.IsNullOrEmpty(result))
                return result;
            
            if (_bag.Count == 0)
                return "No criterion was specified.";

            foreach (KeyValuePair<string, object> key in _bag)
            {
                result += string.Format("[{0}] = '{1}' AND ", key.Key, key.Value);
            }

            return result.Remove(result.Length - 5, 5);
        }

        #endregion

        #region Private Methods
        
        private T GetValue<T>(string name)
        {
            object value;
            if (_bag.TryGetValue(name, out value))
                return (T) value;
        
            return default(T);
        }
        
        #endregion
        
        #region Partial Methods
        
        partial void OnToString(ref string result, ref bool cancel);
        
        #endregion
        
        #region Serialization
        
        protected override void OnGetState(SerializationInfo info, StateMode mode)
        {
            base.OnGetState(info, mode);
            if (_bag.ContainsKey("OrderId")) info.AddValue("OrderId", GetValue< System.Int32 >("OrderId"));
            if (_bag.ContainsKey("UserId")) info.AddValue("UserId", GetValue< System.String >("UserId"));
            if (_bag.ContainsKey("OrderDate")) info.AddValue("OrderDate", GetValue< System.DateTime >("OrderDate"));
            if (_bag.ContainsKey("ShipAddr1")) info.AddValue("ShipAddr1", GetValue< System.String >("ShipAddr1"));
            if (_bag.ContainsKey("ShipAddr2")) info.AddValue("ShipAddr2", GetValue< System.String >("ShipAddr2"));
            if (_bag.ContainsKey("ShipCity")) info.AddValue("ShipCity", GetValue< System.String >("ShipCity"));
            if (_bag.ContainsKey("ShipState")) info.AddValue("ShipState", GetValue< System.String >("ShipState"));
            if (_bag.ContainsKey("ShipZip")) info.AddValue("ShipZip", GetValue< System.String >("ShipZip"));
            if (_bag.ContainsKey("ShipCountry")) info.AddValue("ShipCountry", GetValue< System.String >("ShipCountry"));
            if (_bag.ContainsKey("BillAddr1")) info.AddValue("BillAddr1", GetValue< System.String >("BillAddr1"));
            if (_bag.ContainsKey("BillAddr2")) info.AddValue("BillAddr2", GetValue< System.String >("BillAddr2"));
            if (_bag.ContainsKey("BillCity")) info.AddValue("BillCity", GetValue< System.String >("BillCity"));
            if (_bag.ContainsKey("BillState")) info.AddValue("BillState", GetValue< System.String >("BillState"));
            if (_bag.ContainsKey("BillZip")) info.AddValue("BillZip", GetValue< System.String >("BillZip"));
            if (_bag.ContainsKey("BillCountry")) info.AddValue("BillCountry", GetValue< System.String >("BillCountry"));
            if (_bag.ContainsKey("Courier")) info.AddValue("Courier", GetValue< System.String >("Courier"));
            if (_bag.ContainsKey("TotalPrice")) info.AddValue("TotalPrice", GetValue< System.Decimal >("TotalPrice"));
            if (_bag.ContainsKey("BillToFirstName")) info.AddValue("BillToFirstName", GetValue< System.String >("BillToFirstName"));
            if (_bag.ContainsKey("BillToLastName")) info.AddValue("BillToLastName", GetValue< System.String >("BillToLastName"));
            if (_bag.ContainsKey("ShipToFirstName")) info.AddValue("ShipToFirstName", GetValue< System.String >("ShipToFirstName"));
            if (_bag.ContainsKey("ShipToLastName")) info.AddValue("ShipToLastName", GetValue< System.String >("ShipToLastName"));
            if (_bag.ContainsKey("AuthorizationNumber")) info.AddValue("AuthorizationNumber", GetValue< System.Int32 >("AuthorizationNumber"));
            if (_bag.ContainsKey("Locale")) info.AddValue("Locale", GetValue< System.String >("Locale"));
        }

        protected override void OnSetState(SerializationInfo info, StateMode mode)
        {
            base.OnSetState(info, mode);
            if(info.Values.ContainsKey("OrderId")) _bag["OrderId"] = info.GetValue< System.Int32 >("OrderId");
            if(info.Values.ContainsKey("UserId")) _bag["UserId"] = info.GetValue< System.String >("UserId");
            if(info.Values.ContainsKey("OrderDate")) _bag["OrderDate"] = info.GetValue< System.DateTime >("OrderDate");
            if(info.Values.ContainsKey("ShipAddr1")) _bag["ShipAddr1"] = info.GetValue< System.String >("ShipAddr1");
            if(info.Values.ContainsKey("ShipAddr2")) _bag["ShipAddr2"] = info.GetValue< System.String >("ShipAddr2");
            if(info.Values.ContainsKey("ShipCity")) _bag["ShipCity"] = info.GetValue< System.String >("ShipCity");
            if(info.Values.ContainsKey("ShipState")) _bag["ShipState"] = info.GetValue< System.String >("ShipState");
            if(info.Values.ContainsKey("ShipZip")) _bag["ShipZip"] = info.GetValue< System.String >("ShipZip");
            if(info.Values.ContainsKey("ShipCountry")) _bag["ShipCountry"] = info.GetValue< System.String >("ShipCountry");
            if(info.Values.ContainsKey("BillAddr1")) _bag["BillAddr1"] = info.GetValue< System.String >("BillAddr1");
            if(info.Values.ContainsKey("BillAddr2")) _bag["BillAddr2"] = info.GetValue< System.String >("BillAddr2");
            if(info.Values.ContainsKey("BillCity")) _bag["BillCity"] = info.GetValue< System.String >("BillCity");
            if(info.Values.ContainsKey("BillState")) _bag["BillState"] = info.GetValue< System.String >("BillState");
            if(info.Values.ContainsKey("BillZip")) _bag["BillZip"] = info.GetValue< System.String >("BillZip");
            if(info.Values.ContainsKey("BillCountry")) _bag["BillCountry"] = info.GetValue< System.String >("BillCountry");
            if(info.Values.ContainsKey("Courier")) _bag["Courier"] = info.GetValue< System.String >("Courier");
            if(info.Values.ContainsKey("TotalPrice")) _bag["TotalPrice"] = info.GetValue< System.Decimal >("TotalPrice");
            if(info.Values.ContainsKey("BillToFirstName")) _bag["BillToFirstName"] = info.GetValue< System.String >("BillToFirstName");
            if(info.Values.ContainsKey("BillToLastName")) _bag["BillToLastName"] = info.GetValue< System.String >("BillToLastName");
            if(info.Values.ContainsKey("ShipToFirstName")) _bag["ShipToFirstName"] = info.GetValue< System.String >("ShipToFirstName");
            if(info.Values.ContainsKey("ShipToLastName")) _bag["ShipToLastName"] = info.GetValue< System.String >("ShipToLastName");
            if(info.Values.ContainsKey("AuthorizationNumber")) _bag["AuthorizationNumber"] = info.GetValue< System.Int32 >("AuthorizationNumber");
            if(info.Values.ContainsKey("Locale")) _bag["Locale"] = info.GetValue< System.String >("Locale");
        }

        #endregion
    }
}