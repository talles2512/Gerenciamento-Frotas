function enviardados(){

    if (dados.inputDestino == "" ||  document.dados.tx_destino.value.length <= 5 ) {
        alert("Preencha o Endereço corretamente!");
        document.dados.tx_nome.focus();
        return false;
    }

    else if(document.dados.ocupantes[0].checked){
        
        var elements = document.getElementById("lista-ocupantes").options;
        var contador = 0;
        for(var i = 0; i<=elements.length; i++){
            if(elements[i] != null){
                contador++;
            }
        }

        if(!contador > 0){
            alert("Cadastre ao menos um Ocupante!");
            document.dados.NomeOcupantes.focus();
            return false;
        }
    }

    else {
        console.log(inputs);
    };
}