using GeradorBanco;



CreateData createData = new CreateData();


string caminhoBancoDados = "C:\\Users\\Andre\\OneDrive\\Documents\\repositorios\\Csharp\\WebProway\\BancoDeDados.sqlite";



createData.CriarBancoDeDados(caminhoBancoDados);


Console.WriteLine($"Banco de dados criado com sucesso em: {caminhoBancoDados}");
