//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.8.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//
//     Template: ExistsCommand.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data.SqlClient;

using Csla;

#endregion

namespace PetShop.Tests.StoredProcedures
{
    [Serializable]
    public class ExistsCommand : CommandBase
    {
        #region Constructor(s)

        private ExistsCommand()
        {
        }
        
        #endregion

        #region Authorization Methods

        public static bool CanExecuteCommand()
        {
            return true;
        }

        #endregion

        #region Factory Methods 

        public static bool Execute<T>(T criteria) where T : IGeneratedCriteria
        {
            if (!CanExecuteCommand())
                throw new System.Security.SecurityException("Not authorized to execute command");

            ExistsCommand cmd = new ExistsCommand();
            cmd.BeforeServer(criteria);
            cmd = DataPortal.Execute(cmd);
            cmd.AfterServer();

            return cmd.Result;
        }

        #endregion

        #region Client-side Code

        private IGeneratedCriteria Criteria { get; set; }
        private bool Result { get; set; }

        private void BeforeServer(IGeneratedCriteria criteria)
        {
            Criteria = criteria;
            Result = false;
        }

        private void AfterServer()
        {
        }

        #endregion

        #region Data Access

        protected override void DataPortal_Execute()
        {
            string commandText = string.Format("SELECT COUNT(1) FROM {0} {1}", Criteria.TableName, ADOHelper.BuildWhereStatement(Criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(Criteria.StateBag));
                    Result = (int)command.ExecuteScalar() > 0;
                }
            }
        }

        #endregion
    }
}