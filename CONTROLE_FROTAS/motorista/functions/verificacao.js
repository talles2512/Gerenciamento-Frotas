function enviardados(dados)
{       
   
    if (dados.inputPlaca == "" ||  document.dados.tx_nome.value.length <= 2 ) {
        alert("Preencha o NOME COMPLETO corretamente!");
        document.dados.tx_nome.focus();
        return false;
    }
   

    if (dados.inputRg == "" || document.dados.tx_rg.value.length <= 6) {
        alert("Preencha a RG corretamente!");
        document.dados.tx_rg.focus();
        return false;
    }

    if (document.dados.tx_cpf.value == "" || document.dados.tx_cpf.value.length <= 10) {
        alert("Preencha os CPF corretamente!");
        document.dados.tx_cpf.focus();
        return false;
    }
    if (document.dados.tx_endereco.value == "") {
        alert("Preencha ENDEREÇO corretamente!");
        document.dados.tx_endereco.focus();
        return false;
    }

    if (document.dados.tx_cnh.value == "" || document.dados.tx_cnh.value.length <= 10) {
        alert("Preencha os CNH corretamente!");
        document.dados.tx_cnh.focus();
        return false;
    } 

   

    if (document.dados.tx_telefone1.value == ""||  document.dados.tx_telefone1.value.length <= 9) {
        alert("Preencha TELEFONE corretamente!");
        document.dados.tx_telefone1.focus();
        return false;
    }

    
    if (document.dados.tx_telefone2.value == ""||  document.dados.tx_telefone2.value.length <= 9) {
        alert("Preencha TELEFONE 2 corretamente!");
        document.dados.tx_telefone2.focus();
        return false;
    }


   

      
   


    else {
        alert('Dados cadastrados')
        
       console.log(inputs)

       document.querySelector(".cadastro_veiculos form").reset()
       document.dados.tx_nome.focus();
    };}