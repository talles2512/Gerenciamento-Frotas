function enviardados(dados)
{     
   
    if (document.dados.Apolice.value == "") {
        alert("Preencha o Número da Apolice corretamente!");
        document.dados.Apolice.focus();
        return false;
    }
   

    else if (document.dados.Valor.value.length <= 4){
        alert("Preencha o Valor corretamente!");
        document.dados.Valor.focus();
        return false;
    }

    else if (document.dados.Tipo.value == "0") {
        
        var franquia = document.getElementById("Franquia");
        franquia.setAttribute('required', 'required');

        if (document.dados.ValorFranquia.value.length <= 4){
            alert("Preencha o Valor da Franquia corretamente!");
            document.dados.ValorFranquia.focus();
        }
        return false;
    }

    else if(document.dados.Tipo.value == "1"){
        var franquia = document.getElementById("Franquia");
        franquia.removeAttribute('required', 'required');
        return false;
    }

    else {
        alert("Sucesso");
        console.log(inputs)
        return true;
    }
}