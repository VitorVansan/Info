
namespace ProcessToCsv.Querys
{
    public class Query
    {
        public static string buscaDados = @"SELECT 
												Id,
												SUBSTRING(Dados1,1,30) as Dados1,
												SUBSTRING(Dados2,1,30) as Dados2,
												SUBSTRING(Dados3,1,30) as Dados3,
												SUBSTRING(Dados4,1,30) as Dados4,
												SUBSTRING(Dados5,1,30) as Dados5,
												SUBSTRING(Dados6,1,30) as Dados6,
												SUBSTRING(Dados7,1,30) as Dados7,
												SUBSTRING(Dados8,1,30) as Dados8,
												SUBSTRING(Dados9,1,30) as Dados9,
												SUBSTRING(Dados10,1,30) as Dados10 
									      FROM tb_dados 
										  LIMIT @Pagina, @QuantidadeBusca";
    }
}
