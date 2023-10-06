using ProcessToCsv.Model;
using ProcessToCsv.Repository;
using ProcessToCsv.Service;

Repository repository = new Repository();
CsvService service = new CsvService();
List<Dados> dadosRetornados = new List<Dados>();  

int paginacao = 0;
int quantidadeBusca = 5;


for (int i = 0; i < 10; i++)
{

    dadosRetornados = repository.buscarDados(paginacao, quantidadeBusca);

    paginacao+= quantidadeBusca;

    //escrever csv

    service.insereDadosCsv(dadosRetornados);


}

