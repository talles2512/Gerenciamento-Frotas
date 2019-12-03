function enviardados(dados)
{       
   
    if (dados.inputNome == "" ||  document.dados.tx_nome.value.length <= 2 ) {
        alert("Preencha o Nome corretamente!");
        document.dados.tx_nome.focus();
        return false;
    }
   

    if (dados.inputRG == "" || document.dados.tx_RG.value.length <= 6) {
        alert("Preencha o RG corretamente!");
        document.dados.tx_RG.focus();
        return false;
    }

    if (document.dados.tx_CPF.value == "" || document.dados.tx_CPF.value.length <= 10) {
        alert("Preencha o CPF corretamente!");
        document.dados.tx_CPF.focus();
        return false;
    }

    if (document.dados.tx_Endereco.value == "") {
        alert("Preencha o Endereço corretamente!");
        document.dados.tx_Endereco.focus();
        return false;
    }

    if (document.dados.tx_email.value == "") {
        alert("Preencha o e-mail corretamente!");
        document.dados.tx_email.focus();
        return false;
    }
   
    if (document.dados.tx_Telefone.value == ""||  document.dados.tx_Telefone.value.length <= 9) {
        alert("Preencha o Telefone corretamente!");
        document.dados.tx_Telefone.focus();
        return false;
    }

    else {
        console.log(inputs);
       document.dados.tx_nome.focus();
    };}