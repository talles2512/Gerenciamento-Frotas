let form = document.querySelector(".cadastro_veiculos")
var inputs = document.querySelectorAll(".cadastro_veiculos form input, select")
   
form.addEventListener("submit",function(event){
    event.preventDefault();


        
    let dados = formToJson(inputs)
   const teste  = enviardados(dados);
   console.log(dados)

    var ServicoExterno = CriaJSON(dados);
    console.log(ServicoExterno)
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
     
    
    fetch(new Request('http://localhost:54035/api/ServicoExterno/add', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(ServicoExterno) }))
        .then(response => {
            if (response.status === 200) {
                
                alert('Dados cadastrados')
                document.querySelector(".cadastro_veiculos form").reset()

                return response.json();
            } else {
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
    var nome = dados["Nome"];
    var cnpj = LimpaMascara(dados["Cnpj"]);
    var tipo = LimpaMascara(dados["TipoServ"]);
    var telefone = LimpaMascara(dados["Telefone"]);
    var endereco = dados["Endereco"];
    var email = dados["email"];
    var conveniado;
    var valor = 0;
    var datainicio = null;
    var datavencimento = null;
    
    var options = document.getElementsByName("conveniado");

    options.forEach(element => {
        if(element.checked){
            if(element.value == "true"){
                conveniado = true;
                valor = LimpaReal(dados["Valor"]);
                datainicio = dados["DataInicio"];
                datavencimento = dados["DataVencimento"];
            }
            else{
                conveniado = false;
            }
        }
    });


   var ServicoExterno = {
       Nome : nome,
       CNPJ : cnpj,
       Tipo : tipo,
       Endereco : endereco,
       Email : email,
       Telefone : telefone,
       Conveniado : conveniado,
       ServicoExternoConveniado : {
           DataInicio : datainicio,
           DataVencimento : datavencimento,
           Valor : valor
       }
   }

   return ServicoExterno
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