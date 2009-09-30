//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.7.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Profile.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;

using Csla;
using Csla.Data;
using Csla.Validation;

#endregion

namespace PetShop.Business
{
	[Serializable]
	public partial class Profile : BusinessBase< Profile >
	{
        #region Contructor(s)

		private Profile()
		{ /* Require use of factory methods */ }
        
        internal Profile(SafeDataReader reader)
        {
            Fetch(reader);
        }
        
		#endregion
        
		#region Validation Rules
		
		protected override void AddBusinessRules()
		{
            if(AddBusinessValidationRules())
                return;
            
			ValidationRules.AddRule(CommonRules.StringRequired, _usernameProperty);
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_usernameProperty, 256));
			ValidationRules.AddRule(CommonRules.StringRequired, _applicationNameProperty);
			ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_applicationNameProperty, 256));
		}
		
		#endregion
		
		#region Business Methods


		private static readonly PropertyInfo< int > _uniqueIDProperty = RegisterProperty< int >(p => p.UniqueID);
		[System.ComponentModel.DataObjectField(true, true)]
		public int UniqueID
		{
			get { return GetProperty(_uniqueIDProperty); }				
		}
		
		private static readonly PropertyInfo< string > _usernameProperty = RegisterProperty< string >(p => p.Username);
		public string Username
		{
			get { return GetProperty(_usernameProperty); }				
            set
            { 
                OnPropertyChanging("Username");
                SetProperty(_usernameProperty, value); 
                OnPropertyChanged("Username");
            }
		}
		
		private static readonly PropertyInfo< string > _applicationNameProperty = RegisterProperty< string >(p => p.ApplicationName);
		public string ApplicationName
		{
			get { return GetProperty(_applicationNameProperty); }				
            set
            { 
                OnPropertyChanging("ApplicationName");
                SetProperty(_applicationNameProperty, value); 
                OnPropertyChanged("ApplicationName");
            }
		}
		
		private static readonly PropertyInfo< bool? > _isAnonymousProperty = RegisterProperty< bool? >(p => p.IsAnonymous);
		public bool? IsAnonymous
		{
			get { return GetProperty(_isAnonymousProperty); }				
            set
            { 
                OnPropertyChanging("IsAnonymous");
                SetProperty(_isAnonymousProperty, value); 
                OnPropertyChanged("IsAnonymous");
            }
		}
		
		private static readonly PropertyInfo< SmartDate? > _lastActivityDateProperty = RegisterProperty< SmartDate? >(p => p.LastActivityDate);
		public SmartDate? LastActivityDate
		{
			get { return GetProperty(_lastActivityDateProperty); }				
            set
            { 
                OnPropertyChanging("LastActivityDate");
                SetProperty(_lastActivityDateProperty, value); 
                OnPropertyChanged("LastActivityDate");
            }
		}
		
		private static readonly PropertyInfo< SmartDate? > _lastUpdatedDateProperty = RegisterProperty< SmartDate? >(p => p.LastUpdatedDate);
		public SmartDate? LastUpdatedDate
		{
			get { return GetProperty(_lastUpdatedDateProperty); }				
            set
            { 
                OnPropertyChanging("LastUpdatedDate");
                SetProperty(_lastUpdatedDateProperty, value); 
                OnPropertyChanged("LastUpdatedDate");
            }
		}
		
// NOTE: Many-To-Many support coming soon.
		private static readonly PropertyInfo< AccountList > _accountsProperty = RegisterProperty<AccountList>(p => p.Accounts, Csla.RelationshipTypes.LazyLoad);
		public AccountList Accounts
		{
			get
            {
                if(!FieldManager.FieldExists(_accountsProperty))
                    SetProperty(_accountsProperty, AccountList.GetByUniqueID(UniqueID));

                return GetProperty(_accountsProperty); 
            }
		}

		private static readonly PropertyInfo< CartList > _cartsProperty = RegisterProperty<CartList>(p => p.Carts, Csla.RelationshipTypes.LazyLoad);
		public CartList Carts
		{
			get
            {
                if(!FieldManager.FieldExists(_cartsProperty))
                    SetProperty(_cartsProperty, CartList.GetByUniqueID(UniqueID));

                return GetProperty(_cartsProperty); 
            }
		}

		#endregion
				
		#region Root Factory Methods 
		
		public static Profile NewProfile()
		{
			return DataPortal.Create< Profile >();
		}
		
		public static Profile GetProfile(int uniqueID)
		{
			return DataPortal.Fetch< Profile >(
                new ProfileCriteria(uniqueID));
		}

        public static void DeleteProfile(int uniqueID)
		{
                DataPortal.Delete(new ProfileCriteria(uniqueID));
		}
		
		#endregion
		
		#region Child Factory Methods 
		
		internal static Profile NewProfileChild()
		{
			return DataPortal.CreateChild< Profile >();
		}
		
		public static Profile GetProfileChild(int uniqueID)
		{
            return DataPortal.FetchChild< Profile >(
				new ProfileCriteria(uniqueID));
		}

		#endregion
		
	}
}