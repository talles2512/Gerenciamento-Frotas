
    fetch('https://reqres.in/api/users')
    .then(function(response){
        response.json().then(function(data){
            return(data);
          });
    })
    


    .catch(function(err){
        console.error('Failed retrieving information', err);
      });
    
    
        


