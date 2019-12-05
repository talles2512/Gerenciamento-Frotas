function enviardados(dados)
{     

    if (document.dados.Valor.value.length <= 4){
        alert("Preencha o Valor corretamente!");
        document.dados.Valor.focus();
        return false;
    }

    if (document.dados.Descricao.value == "" || document.dados.Descricao.value.length <= 3) {
        alert("Preencha a Descrição corretamente!");
        document.dados.Nome.focus();
        return false;
    }

    else {     
       console.log(inputs)
    };}