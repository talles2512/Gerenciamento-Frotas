function enviardados(dados)
{     
   
    if (dados.inputPlaca == "" || document.dados.tx_apolice.value.length <= 3) {
        alert("Preencha o Numero da Apolice corretamente!");
        document.dados.tx_apolice.focus();
        return false;
    }
   

    if (dados.inputPlaca== "" || document.dados.tx_segurado.value.length <= 6) {
        alert("Preencha a O Item segurado corretamente!");
        document.dados.tx_segurado.focus();
        return false;
    }

    if (document.inputPassword4 == "" || document.dados.tx_cpf.value.length <=10) {
        alert("Preencha os CPF corretamente!");
        document.dados.tx_cpf.focus();
        return false;
    }

    if (document.inputAddress == "" || document.dados.tx_cliente.value.length <=10) {
        alert("Preencha os ENDEREÇO corretamente!");
        document.dados.tx_cliente.focus();
        return false;
    }

    if (document.inputAddress3== "" || document.dados.tx_telefone.value.length <=9) {
        alert("Preencha os TELEFONE corretamente!");
        document.dados.tx_telefone.focus();
        return false;
    }


    
    if (document.inputAddress2== "" || document.dados.tx_email.value.length <=9) {
        alert("Preencha os E-MAIL corretamente!");
        document.dados.tx_email.focus();
        return false;
    }


   

      
   


    else {
        alert('Dados cadastrados')
        
       console.log(inputs)

       document.querySelector(".cadastro_veiculos form").reset()
       document.dados.tx_apolice.focus();
    };}