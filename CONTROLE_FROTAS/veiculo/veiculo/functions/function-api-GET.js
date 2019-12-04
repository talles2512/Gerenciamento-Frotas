function GET(pesquisa){
  fetch('http://localhost:54035/api/veiculo?pesquisa='+pesquisa)
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

  var table = document.getElementById('tabela-veiculos');

      data.forEach(element => {
          var row = table.insertRow(1);
          row.innerHTML = "<td>"+ element["Placa"]+"</td>"
                          +"<td>"+element["Modelo"]+"</td>"
                          +"<td>"+element["Marca"]+"</td>"
                          +"<td>"+element["Chassi"]+"</td>"
                          +"<td>"+NomeiaAlugado(element["Alugado"])+"</td>";
      });
}

function NomeiaAlugado(alugado){
    var tipo;
    if(alugado){
        tipo = "Sim";
    }
    else{
        tipo = "Não";
    }

    return tipo;
}
    
        


