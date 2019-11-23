function enviardados() {

    if (document.dados.tx_nome.value == "" || document.dados.tx_nome.value.length <= 5) {
        alert("Preencha os NOME COMPLETO corretamente!");
        document.dados.tx_nome.focus();
        return false;
    }
   

    if (document.dados.tx_rg.value == "" || document.dados.tx_rg.value.length <= 5) {
        alert("Preencha os RG corretamente!");
        document.dados.tx_rg.focus();
        return false;
    }

    if (document.dados.tx_cpf.value == "" || document.dados.tx_cpf.value.length <= 8) {
        alert("Preencha os CPF corretamente!");
        document.dados.tx_cpf.focus();
        return false;
    }

    if (document.dados.tx_data.value == "" || document.dados.tx_data.value.length <= 8) {
        alert("Preencha os RG corretamente!");
        document.dados.tx_data.focus();
        return false;
    }

    if (document.dados.tx_endereco.value == "" || document.dados.tx_endereco.value.length <= 8) {
        alert("Preencha o ENDEREÇO corretamente!");
        document.dados.tx_endereco.focus();
        return false;
    }


    if (document.dados.tx_telefone.value == "" || document.dados.tx_telefone.value.length <= 9) {
        alert("Preencha o TELEFONE corretamente!");
        document.dados.tx_telefone.focus();
        return false;
    }


    if (document.dados.tx_telefone.value == "" || document.dados.tx_telefone.value.length <= 9) {
        alert("Preencha o TELEFONE corretamente!");
        document.dados.tx_telefone.focus();
        return false;
    }

    if (document.dados.tx_cnh.value == "" || document.dados.tx_cnh.value.length <= 10) {
        alert("Preencha o CNH corretamente!");
        document.dados.tx_cnh.focus();
        return false;
    }
    else {

        alert("Dados cadastrado com sucesso");}











    };