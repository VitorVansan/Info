using ProcessToCsv.Model;
using ProcessToCsv.Repository;
using ProcessToCsv.Service;

Repository repository = new Repository();
CsvService service = new CsvService();
List<Dados> dadosRetornados = new List<Dados>();  

int paginacao = 0;
int quantidadeBusca = 5000;

//Efetuando o select de 5000 linhas e 6000 vezes, um total de 30 milhões.
for (int i = 0; i < 6000; i++)
{

    dadosRetornados = repository.buscarDados(paginacao, quantidadeBusca);

    paginacao+= quantidadeBusca;

    //escrever csv

    service.insereDadosCsv(dadosRetornados);


}

