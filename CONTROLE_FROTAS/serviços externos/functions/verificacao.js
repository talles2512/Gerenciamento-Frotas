function enviardados(dados)
{     
   
    if (document.dados.Nome.value == "" || document.dados.Nome.value.length <= 3) {
        alert("Preencha o Nome da Empresa corretamente!");
        document.dados.Nome.focus();
        return false;
    }
   

    else if (document.dados.Cnpj.value.length < 18) {
        alert("Preencha o CNPJ corretamente!");
        document.dados.Cnpj.focus();
        return false;
    }

    else if (document.dados.Telefone.value.length < 14) {
        alert("Preencha o Telefone corretamente!");
        document.dados.Telefone.focus();
        return false;
    }

    else if (document.dados.Endereco.value == "" || document.dados.Endereco.value.length <= 3) {
        alert("Preencha o Endereço corretamente!");
        document.dados.Endereco.focus();
        return false;
    }

    else if(document.dados.conveniado[0].checked){

        var datainicio = document.getElementById("DataInicio");
        datainicio.setAttribute('required', 'required');

        var datavencimento = document.getElementById("DataVencimento");
        datavencimento.setAttribute('required', 'required');

        if (document.dados.Valor.value.length <= 4){
            alert("Preencha o Valor corretamente!");
            document.dados.Valor.focus();
            return false;
        }
    }

    else if(document.dados.conveniado[1].checked){
        var datainicio = document.getElementById("DataInicio");
        datainicio.removeAttribute('required', 'required');

        var datavencimento = document.getElementById("DataVencimento");
        datavencimento.removeAttribute('required', 'required');
    }

    else {
        alert("Sucesso");
        console.log(inputs)
    }
}