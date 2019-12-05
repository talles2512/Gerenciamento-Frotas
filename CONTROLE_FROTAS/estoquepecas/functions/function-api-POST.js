let form = document.querySelector(".cadastro_veiculos")
var inputs = document.querySelectorAll(".cadastro_veiculos form input, select")
   
form.addEventListener("submit",function(event){
    event.preventDefault();


        
    let dados = formToJson(inputs)
   const teste  = enviardados(dados);
   console.log(teste)

    var Peca = CriaJSON(dados);
    console.log(Peca)
    if(teste == false){
        return false;
    }
     
    fetch(new Request('http://localhost:54035/api/EstoquePecas/add', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(Peca) }))
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
    var descricao = dados["Descricao"];
    var valor = dados["Valor"];
    var qtd = dados["Quantidade"];

   var Peca = {
       Descricao : descricao,
       ValorUnit : valor,
       Quantidade : qtd,
   }

   return Peca
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