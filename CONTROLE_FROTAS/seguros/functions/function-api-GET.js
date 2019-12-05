function GET(pesquisa){
  fetch('http://localhost:54035/api/Seguro?pesquisa='+pesquisa)
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

  var table = document.getElementById('tabela-seguros');

      data.forEach(element => {
          var row = table.insertRow(1);
          row.innerHTML = "<td>"+ element["NumeroApolice"]+"</td>"
                          +"<td>"+element["ItemSegurado"]+"</td>"
                          +"<td>"+element["CNPJ"]+"</td>"
                          +"<td>"+NomeiaTipo(element["Tipo"])+"</td>"
                          +"<td>"+element["Valor"]+"</td>"
                          +"<td>"+element["DataInicio"]+"</td>"
                          +"<td>"+element["FimVigencia"]+"</td>";
      });
}

function NomeiaTipo(tipo){
  var tipos = ["Vida", "Automóvel"];
  return tipos[tipo];
}
    
        


