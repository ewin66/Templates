//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.7.X CodeSmith Templates.
//	   Changes to this template will not be lost.
//
//     Template: EditableRootList.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;
using System.Collections.Generic;
using Csla;

#endregion

namespace PetShop.Business
{
	public partial class ProfileList
	{
		#region Authorization Rules

		private static void AddObjectAuthorizationRules()
		{
			// TODO: add authorization rules
			//AuthorizationRules.AllowGet(typeof(ProfileList), "Role");
		}

		#endregion

        #region Custom Criteria

        public static ProfileList GetProfileList(string username)
        {
            return DataPortal.Fetch<ProfileList>(new ProfileCriteria { Username = username });
        }

        #endregion
    }
}