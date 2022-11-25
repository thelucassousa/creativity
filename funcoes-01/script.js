const send = document.querySelector('#send');

send.addEventListener('click', function(e){
    e.preventDefault();

    const ageQuestion = document.querySelector('#ageQuestion');
    const value = ageQuestion.value;


     if(value >= 18){
        return alert('Welcome!');
    } else{
        return alert('Below the legal age!');
            }
    

})