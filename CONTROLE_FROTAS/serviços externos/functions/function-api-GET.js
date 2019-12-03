function GET(pesquisa){
  fetch('http://localhost:54035/api/servicoexterno?pesquisa='+pesquisa)
            .then(function(response){
                if(response.ok){
                    response.json().then(function(data){
                        console.log(data);
                        PopulaTabela(data);
                      });
                }
        
            })
            .catch(function(err){
                console.error('Failed retrieving information', err);
              });
}

function PopulaTabela(data){
  var cabecalho = document.getElementById("cabecalho");
  var rows = document.querySelectorAll("table tr");

  rows.forEach(element => {
      if(element != cabecalho){
          element.remove();
      }
  });

  var table = document.getElementById('tabela-servicos-externos');

      data.forEach(element => {
          var row = table.insertRow(1);
          row.innerHTML = "<td>"+ element["CNPJ"]+"</td>"
                          +"<td>"+element["Nome"]+"</td>"
                          +"<td>"+element["Telefone"]+"</td>"
                          +"<td>"+element["Email"]+"</td>"
                          +"<td>"+element["Endereco"]+"</td>"
                          +"<td>"+NomeiaServEx(element["Tipo"])+"</td>";
      });
}

function NomeiaServEx(tipo){
  var servicos = ["Oficina", "Seguradora", "Posto", "Garagem/Estacionamento"];
  return servicos[tipo];
}