
    fetch('https://localhost:44357/api/clientes')
    .then(function(response){
        response.json().then(function(data){
            return(data);
          });
    })
    


    .catch(function(err){
        console.error('Failed retrieving information', err);
      });
    
    
        


