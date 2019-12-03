function enviardados(dados)
{       
   
    if (dados.inputNome == "" ||  document.dados.tx_nome.value.length <= 2 ) {
        alert("Preencha o NOME COMPLETO corretamente!");
        document.dados.tx_nome.focus();
        return false;
    }
   

    if (dados.inputRg == "" || document.dados.tx_RG.value.length <= 6) {
        alert("Preencha a RG corretamente!");
        document.dados.tx_RG.focus();
        return false;
    }

    if (document.dados.tx_CPF.value == "" || document.dados.tx_CPF.value.length <= 10) {
        alert("Preencha os CPF corretamente!");
        document.dados.tx_CPF.focus();
        return false;
    }
    if (document.dados.tx_Endereco.value == "") {
        alert("Preencha ENDEREÇO corretamente!");
        document.dados.tx_Endereco.focus();
        return false;
    }

    if (document.dados.tx_CNH_Numero.value == "" || document.dados.tx_CNH_Numero.value.length <= 10) {
        alert("Preencha os CNH corretamente!");
        document.dados.tx_CNH_Numero.focus();
        return false;
    } 

   

    if (document.dados.tx_Telefone.value == ""||  document.dados.tx_Telefone.value.length <= 9) {
        alert("Preencha o TELEFONE corretamente!");
        document.dados.tx_Telefone.focus();
        return false;
    }

    
    if (document.dados.tx_TelefoneContato.value == ""||  document.dados.tx_TelefoneContato.value.length <= 9) {
        alert("Preencha o TELEFONE CONTATO corretamente!");
        document.dados.tx_TelefoneContato.focus();
        return false;
    }

    if (document.dados.tx_CNH_OrgaoEmissor.value == "" || document.dados.tx_CNH_OrgaoEmissor.value.length <= 1) {
        alert("Preencha o Orgão Emissor corretamente!");
        document.dados.tx_CNH_OrgaoEmissor.focus();
        return false;
    }
   

      
   


    else {
        console.log(inputs);
       document.dados.tx_nome.focus();
    };}