function GET(pesquisa){
  fetch('http://localhost:54035/api/motorista?pesquisa='+pesquisa)
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

  var table = document.getElementById('tabela-motoristas');

      data.forEach(element => {
          var row = table.insertRow(1);
          row.innerHTML = "<td>"+ element["Name"]+"</td>"
                          +"<td>"+element["CPF"]+"</td>"
                          +"<td>"+element["Endereco"]+"</td>"
                          +"<td>"+element["Telefone"]+"</td>";
      });
}
    
        


