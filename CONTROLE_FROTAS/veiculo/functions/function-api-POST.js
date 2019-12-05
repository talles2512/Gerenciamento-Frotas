let form = document.querySelector(".cadastro_veiculos")
let inputs = document.querySelectorAll(".cadastro_veiculos form input, select")
   
form.addEventListener("submit",function(event){
    event.preventDefault();


    let dados = formToJson(inputs)
   const teste  = enviardados(dados);
   console.log(teste)
    var Veiculo = CriaJSON(dados);
    var VeiculoAlugado = Veiculo.VeiculoAlugdo;
    console.log(Veiculo)
    if(teste == false){
        return false;
    }

    fetch(new Request('http://localhost:54035/api/Veiculo/add', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(Veiculo) }))
        .then(response => {
            if (response.status === 200) {
                    alert('Dados cadastrados');
                    document.querySelector(".cadastro_veiculos form").reset();
                    LimparOcupantes();
                    MudaOcupantes();
                
                return response.json();
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
    var placa = LimpaMascara(dados["Placa"].toUpperCase());
    var marca = dados["Marca"];
    var modelo = dados["Modelo"];
    var chassi = dados["Chassi"].toUpperCase();
    var ano = dados["Ano"];
    var cor = dados["Cor"];
    var combustivel = dados["Comb"];
    var situacao = true;
    var alugado;
    var valor;
    var dtinicio;
    var dtfim;
    
    var options = document.getElementsByName("alugados");

    options.forEach(element => {
        if(element.checked){
            if(element.value == "true"){
                alugado = true;
                valor = dados["Valor"];
                dtinicio = dados["DtInicio"];
                dtfim = dados["DtFim"];
            }
            else{
                alugado = false;
            }
        }
        });
        
   var Veiculo = {
       Placa : placa,
       Marca : marca,
       Modelo : modelo,
       Chassi : chassi,
       Ano : ano,
       Cor : cor,
       Combustivel : combustivel,
       Alugado : alugado,
       SituacaoVeiculo : situacao,
       VeiculoAlugado :{
           Valor: valor,
           DataInicio : dtinicio,
           DataVencimento : dtfim
       }
   }

   return Veiculo;
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

function CortarIdentificador(element){
    for(var i = 0; i<=element.length; i++){
        if(element[i] == "-"){
            var cpf = element.substring(++i,element.length);
            return cpf;
        }
    }
}

function CortarNome(element){
    for(var i = 0; i<=element.length; i++){
        if(element[i] == "-"){
            var nome = element.substring(0,i--);
            return nome;
        }
    }
}
