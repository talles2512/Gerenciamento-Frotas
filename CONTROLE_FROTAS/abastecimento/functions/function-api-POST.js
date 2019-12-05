let form = document.querySelector(".cadastro_veiculos")
var inputs = document.querySelectorAll(".cadastro_veiculos form input, select")
   
form.addEventListener("submit",function(event){
    event.preventDefault();


        
    let dados = formToJson(inputs)
    const teste  = enviardados(dados);
   console.log(teste);

    var Abastecimento = CriaJSON(dados);
    console.log(Abastecimento)
    if(teste == false){
        return false;
    }

    // console.log(JSON.stringify(dados))
    
     //fetch('http://localhost:44367/api/Veiculos', {
        //method: 'get',
        //mode: 'cors',
        
        // headers: {
        //     'Accept': 'application/json',
        //     'Content-Type': 'application/json',
        //     'Access-Control-Allow-Origin': '*',
        //     'Access-Control-Allow-Credentials': true
        // }
        // body: JSON.stringify({id:1})
    //})
     
    
    fetch(new Request('http://localhost:54035/api/Abastecimento/add', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(Abastecimento) }))
        .then(response => {
            if (response.status === 200) {
                
                alert('Dados cadastrados')
                document.querySelector(".cadastro_veiculos form").reset()

                return response.json();
            }
            else if(response.status == 406){
                alert("Combustível escolhido é incompatível com o veículo!");
            }
             else {
                throw new Error('Ops! Houve um erro em nosso servidor.');
            }
        })
        .then(response => {
            console.debug(response);
            // ...
        }).catch(error => {
            console.error(error);
        });
        
        


})

function formToJson(inputs){
    let dados = {}
    inputs.forEach(input => {
       
        dados[input.id] = input.value 
    });

   
    return dados
}

function CriaJSON(dados){
    var placa = dados["PlacaVeiculo"];
    var cnpj = dados["CnpjPosto"];
    var data = dados["Data"];
    var tipo = dados["Tipo"];
    var litros = dados["Litros"];
    var valor = LimpaReal(dados["Valor"]);

   var Abastecimento = {
       CNPJ : cnpj,
       Data : data,
       Litros : litros,
       Placa : placa,
       Tipo : tipo,
       Valor : valor
   }

   return Abastecimento
}

function LimpaMascara(input){
    var strings = [".", "/", "-", ",", "(", ")", " "];
    
    for(var i = 0; i<=strings.length; i++){
        input = input.replace(strings[i],"");
    }

    for(var i = 0; i<=strings.length; i++){
        input = input.replace(strings[i],"");
    }

    return input;
}

function LimpaReal(input){
    var strings = [".", "R", "$", " "];
    
    for(var i = 0; i<=strings.length; i++){
        input = input.replace(strings[i],"");
    }

    for(var i = 0; i<=strings.length; i++){
        input = input.replace(strings[i],"");
    }

    return input;
}


function VerificaLitros(input){
    var strings = [".", "R", "$", " "];
    
    for(var i = 0; i<=strings.length; i++){
        input = input.replace(strings[i],"");
    }

    for(var i = 0; i<=strings.length; i++){
        input = input.replace(strings[i],"");
    }

    return input;
}