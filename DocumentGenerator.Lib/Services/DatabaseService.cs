using DocumentGenerator.Lib.Interfaces;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DocumentGenerator.Lib.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly ILogRegisterService _gravadorDeLogs;

        public DatabaseService(ILogRegisterService gravadorDeLogs)
        {
            _gravadorDeLogs = gravadorDeLogs;
        }

        public void BackupDataBase()
        {
            try
            {
                using SqlConnection conn = new(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                conn.Open();
                var sql = @"BACKUP DATABASE [generatePerson] TO  DISK = N'C:\Projetos\DocumentGenerator\DocumentGenerator.Lib\Database\Backup\generatePerson.bak' WITH NOFORMAT, INIT,  NAME = N'generatePerson-Completo Banco de Dados Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                using SqlCommand cmd = new(sql, conn);
                var result = cmd.ExecuteNonQuery();
                if (result == -1)
                {
                    _gravadorDeLogs.GravaLog("Backup do banco de dados realizado com sucesso", "database-bkp.txt");
                }
            }
            catch (System.Exception ex)
            {
                _gravadorDeLogs.GravaLog(ex.ToString(), "erro-geral.txt");
            }
        }
    }
}