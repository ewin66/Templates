﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.1413, CSLA Framework: v3.8.2.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Account.cs'.
//
//     Template: EditableChild.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;
using Csla.Validation;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.AccountFactoryName)]
    public partial class Account : BusinessBase< Account >
    {
        #region Contructor(s)

        private Account()
        {
            MarkAsChild();
        }

        internal Account(System.Int32 accountId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_accountIdProperty, accountId);
            }

            MarkAsChild();
        }
        #endregion

        #region Validation Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            ValidationRules.AddRule(CommonRules.StringRequired, _emailProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_emailProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _firstNameProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_firstNameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _lastNameProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_lastNameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _address1Property);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_address1Property, 80));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_address2Property, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _cityProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_cityProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _stateProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_stateProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _zipProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_zipProperty, 20));
            ValidationRules.AddRule(CommonRules.StringRequired, _countryProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_countryProperty, 20));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_phoneProperty, 20));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.Int32 > _accountIdProperty = RegisterProperty< System.Int32 >(p => p.AccountId);
		[System.ComponentModel.DataObjectField(true, true)]
        public System.Int32 AccountId
        {
            get { return GetProperty(_accountIdProperty); }
            internal set{ SetProperty(_accountIdProperty, value); }
        }

        private static readonly PropertyInfo< System.Int32 > _uniqueIDProperty = RegisterProperty< System.Int32 >(p => p.UniqueID);
        public System.Int32 UniqueID
        {
            get { return GetProperty(_uniqueIDProperty); }
            set{ SetProperty(_uniqueIDProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _emailProperty = RegisterProperty< System.String >(p => p.Email);
        public System.String Email
        {
            get { return GetProperty(_emailProperty); }
            set{ SetProperty(_emailProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _firstNameProperty = RegisterProperty< System.String >(p => p.FirstName);
        public System.String FirstName
        {
            get { return GetProperty(_firstNameProperty); }
            set{ SetProperty(_firstNameProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _lastNameProperty = RegisterProperty< System.String >(p => p.LastName);
        public System.String LastName
        {
            get { return GetProperty(_lastNameProperty); }
            set{ SetProperty(_lastNameProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _address1Property = RegisterProperty< System.String >(p => p.Address1);
        public System.String Address1
        {
            get { return GetProperty(_address1Property); }
            set{ SetProperty(_address1Property, value); }
        }

        private static readonly PropertyInfo< System.String > _address2Property = RegisterProperty< System.String >(p => p.Address2);
        public System.String Address2
        {
            get { return GetProperty(_address2Property); }
            set{ SetProperty(_address2Property, value); }
        }

        private static readonly PropertyInfo< System.String > _cityProperty = RegisterProperty< System.String >(p => p.City);
        public System.String City
        {
            get { return GetProperty(_cityProperty); }
            set{ SetProperty(_cityProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _stateProperty = RegisterProperty< System.String >(p => p.State);
        public System.String State
        {
            get { return GetProperty(_stateProperty); }
            set{ SetProperty(_stateProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _zipProperty = RegisterProperty< System.String >(p => p.Zip);
        public System.String Zip
        {
            get { return GetProperty(_zipProperty); }
            set{ SetProperty(_zipProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _countryProperty = RegisterProperty< System.String >(p => p.Country);
        public System.String Country
        {
            get { return GetProperty(_countryProperty); }
            set{ SetProperty(_countryProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _phoneProperty = RegisterProperty< System.String >(p => p.Phone);
        public System.String Phone
        {
            get { return GetProperty(_phoneProperty); }
            set{ SetProperty(_phoneProperty, value); }
        }

        //AssociatedManyToOne
        private static readonly PropertyInfo< Profile > _profileMemberProperty = RegisterProperty< Profile >(p => p.ProfileMember, Csla.RelationshipTypes.Child);
        public Profile ProfileMember
        {
            get
            {
                if(!FieldManager.FieldExists(_profileMemberProperty))
                {
                    if(IsNew || !PetShop.Tests.ObjF.StoredProcedures.Profile.Exists(new PetShop.Tests.ObjF.StoredProcedures.ProfileCriteria {UniqueID = UniqueID}))
                        LoadProperty(_profileMemberProperty, PetShop.Tests.ObjF.StoredProcedures.Profile.NewProfile());
                    else
                        LoadProperty(_profileMemberProperty, PetShop.Tests.ObjF.StoredProcedures.Profile.GetByUniqueID(UniqueID));
                }

                return GetProperty(_profileMemberProperty); 
            }
        }


        #endregion

        #region Factory Methods 

        internal static Account NewAccount()
        {
            return DataPortal.CreateChild< Account >();
        }

        internal static Account GetByAccountId(System.Int32 accountId)
        {
            return DataPortal.FetchChild< Account >(
                new AccountCriteria {AccountId = accountId});
        }

        internal static Account GetByUniqueID(System.Int32 uniqueID)
        {
            return DataPortal.FetchChild< Account >(
                new AccountCriteria {UniqueID = uniqueID});
        }

        #endregion

        #region Exists Command

        public static bool Exists(AccountCriteria criteria)
        {
            return ExistsCommand.Execute(criteria);
        }

        #endregion

        #region Overridden properties

        /// <summary>
        /// Returns true if the business object or any of its children properties are dirty.
        /// </summary>
        public override bool IsDirty
        {
            get
            {
                if (base.IsDirty) return true;
                if (FieldManager.FieldExists(_profileMemberProperty) && ProfileMember.IsDirty) return true;

                return false;
            }
        }

        #endregion


    }
}