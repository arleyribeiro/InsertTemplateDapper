using System;
using System.Data.SqlClient;
using Dapper;
using Templates.Domain;

namespace Templates.DataAccess
{
    public class TemplateRepository
    {
        private readonly string _connectionString;
        public TemplateRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public int Insert(TemplateEntity template)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                return connection.ExecuteScalar<int>(@"INSERT INTO [dbo].[NTFTBLTXTTEMPLATENOTIFICA]
                                                                    ([HDRDTHHOR]
                                                                    ,[HDRCODUSU]
                                                                    ,[HDRCODLCK]
                                                                    ,[HDRDTHINS]
                                                                    ,[HDRCODETC]
                                                                    ,[HDRCODPRG]
                                                                    ,[TXTCODTEMPLATE]
                                                                    ,[TXTDESTEMPLATE]
                                                                    ,[TXTSIT])
                                                                VALUES
                                                                    (GETDATE()
                                                                        ,'teste'
                                                                        ,1
                                                                        ,GETDATE()
                                                                        ,'teste'
                                                                        ,'teste'
                                                                        ,@CodTemplate
                                                                        ,@DestTemplate
                                                                        ,'A')
                                                                SELECT SCOPE_IDENTITY()", template);
            }
        }
    }
}
