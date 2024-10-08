﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public partial class BackendExamHubContext
    {
        private IBackendExamHubContextProcedures _procedures;

        public virtual IBackendExamHubContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new BackendExamHubContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IBackendExamHubContextProcedures GetProcedures()
        {
            return Procedures;
        }
    }

    public partial class BackendExamHubContextProcedures : IBackendExamHubContextProcedures
    {
        private readonly BackendExamHubContext _context;

        public BackendExamHubContextProcedures(BackendExamHubContext context)
        {
            _context = context;
        }

        public virtual async Task<List<InsertMyOfficeExecutionLogResult>> InsertMyOfficeExecutionLogAsync(string StoredPrograms, Guid? GroupID, bool? isCustomDebug, string ExecutionProgram, string ExecutionInfo, bool? VerifyNeeded, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "StoredPrograms",
                    Size = 240,
                    Value = StoredPrograms ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "GroupID",
                    Value = GroupID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.UniqueIdentifier,
                },
                new SqlParameter
                {
                    ParameterName = "isCustomDebug",
                    Value = isCustomDebug ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Bit,
                },
                new SqlParameter
                {
                    ParameterName = "ExecutionProgram",
                    Size = 240,
                    Value = ExecutionProgram ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "ExecutionInfo",
                    Size = 1000,
                    Value = ExecutionInfo ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "VerifyNeeded",
                    Value = VerifyNeeded ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Bit,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<InsertMyOfficeExecutionLogResult>("EXEC @returnValue = [dbo].[InsertMyOfficeExecutionLog] @StoredPrograms = @StoredPrograms, @GroupID = @GroupID, @isCustomDebug = @isCustomDebug, @ExecutionProgram = @ExecutionProgram, @ExecutionInfo = @ExecutionInfo, @VerifyNeeded = @VerifyNeeded", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> NEWSIDAsync(string TableName, OutputParameter<string> ReturnSID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterReturnSID = new SqlParameter
            {
                ParameterName = "ReturnSID",
                Size = 40,
                Direction = System.Data.ParameterDirection.InputOutput,
                Value = ReturnSID?._value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            };
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "TableName",
                    Size = 256,
                    Value = TableName ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameterReturnSID,
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[NEWSID] @TableName = @TableName, @ReturnSID = @ReturnSID OUTPUT", sqlParameters, cancellationToken);

            ReturnSID.SetValue(parameterReturnSID.Value);
            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<usp_AddLogResult>> usp_AddLogAsync(byte? _InBox_ReadID, string _InBox_SPNAME, Guid? _InBox_GroupID, string _InBox_ExProgram, string _InBox_ActionJSON, OutputParameter<string> _OutBox_ReturnValues, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameter_OutBox_ReturnValues = new SqlParameter
            {
                ParameterName = "_OutBox_ReturnValues",
                Size = -1,
                Direction = System.Data.ParameterDirection.InputOutput,
                Value = _OutBox_ReturnValues?._value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            };
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "_InBox_ReadID",
                    Value = _InBox_ReadID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.TinyInt,
                },
                new SqlParameter
                {
                    ParameterName = "_InBox_SPNAME",
                    Size = 240,
                    Value = _InBox_SPNAME ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "_InBox_GroupID",
                    Value = _InBox_GroupID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.UniqueIdentifier,
                },
                new SqlParameter
                {
                    ParameterName = "_InBox_ExProgram",
                    Size = 80,
                    Value = _InBox_ExProgram ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "_InBox_ActionJSON",
                    Size = -1,
                    Value = _InBox_ActionJSON ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameter_OutBox_ReturnValues,
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<usp_AddLogResult>("EXEC @returnValue = [dbo].[usp_AddLog] @_InBox_ReadID = @_InBox_ReadID, @_InBox_SPNAME = @_InBox_SPNAME, @_InBox_GroupID = @_InBox_GroupID, @_InBox_ExProgram = @_InBox_ExProgram, @_InBox_ActionJSON = @_InBox_ActionJSON, @_OutBox_ReturnValues = @_OutBox_ReturnValues OUTPUT", sqlParameters, cancellationToken);

            _OutBox_ReturnValues.SetValue(parameter_OutBox_ReturnValues.Value);
            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<usp_DeleteMyofficeACPDResult>> usp_DeleteMyofficeACPDAsync(string SID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "SID",
                    Size = 40,
                    Value = SID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<usp_DeleteMyofficeACPDResult>("EXEC @returnValue = [dbo].[usp_DeleteMyofficeACPD] @SID = @SID", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<usp_GetMyofficeACPDResult>> usp_GetMyofficeACPDAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<usp_GetMyofficeACPDResult>("EXEC @returnValue = [dbo].[usp_GetMyofficeACPD]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<usp_InsertMyofficeACPDResult>> usp_InsertMyofficeACPDAsync(string JsonData, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "JsonData",
                    Size = -1,
                    Value = JsonData ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<usp_InsertMyofficeACPDResult>("EXEC @returnValue = [dbo].[usp_InsertMyofficeACPD] @JsonData = @JsonData", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<usp_UpdateMyofficeACPDResult>> usp_UpdateMyofficeACPDAsync(string JsonData, string SID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "JsonData",
                    Size = -1,
                    Value = JsonData ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "SID",
                    Size = 40,
                    Value = SID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<usp_UpdateMyofficeACPDResult>("EXEC @returnValue = [dbo].[usp_UpdateMyofficeACPD] @JsonData = @JsonData, @SID = @SID", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
