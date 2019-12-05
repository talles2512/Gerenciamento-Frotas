function enviardados(dados)
{     

    if (document.dados.Valor.value.length <= 4){
        alert("Preencha o Valor corretamente!");
        document.dados.Valor.focus();
        return false;
    }

    if (document.dados.Litros.value.length < 1){
        alert("Preencha o Litros corretamente!");
        document.dados.Valor.focus();
        return false;
    }

    else {     
       console.log(inputs)
    };}