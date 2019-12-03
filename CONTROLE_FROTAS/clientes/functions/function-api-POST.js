let form = document.querySelector(".cadastro_veiculos")
var inputs = document.querySelectorAll(".cadastro_veiculos form input, select")
   
form.addEventListener("submit",function(event){
    event.preventDefault();


        
    let dados = formToJson(inputs)
   const teste  = enviardados(dados);
   console.log(teste)

    var Cliente = CriaJSON(dados);
    console.log(Cliente)
    if(teste == false){
        return false;
    }
     
    fetch(new Request('http://localhost:54035/api/Cliente/add', { method: 'POST',
         headers: new Headers(
             {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
             }
         ),
         body: JSON.stringify(Cliente) }))
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
    var name = dados["Nome"];
    var cpf = LimpaMascara(dados["Cpf"]);
    var rg = LimpaMascara(dados["RG"]);
    var endereco = dados["Endereco"];
    var email = dados["email"];
    var dataNascimento = dados["DataNascimento"];
    var telefone = LimpaMascara(dados["Telefone"]);

   var Cliente = {
       CPF : cpf,
       Nome : name,
       RG : rg,
       Endereco : endereco,
       Telefone : telefone,
       Email : email,
       DataNascimento : dataNascimento,
   }

   return Cliente
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