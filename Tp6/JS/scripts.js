'use-strict'
window.addEventListener('load' , function(){
    let Formulario = document.querySelector('#Formulario');

    Formulario.addEventListener('submit' , function(){
        console.log("funca")
        let Nombre = document.querySelector('#Nombre').value;
        let Apellido = document.querySelector('#Apellido').value;
        let Edad = parseInt(document.querySelector('#Edad').value);
        
        if (Nombre.trim() == ""|| Nombre.trim().lenght == 0 )
        {
            alert("El nombre no es valido")
            return false;

        }
        if (Apellido.trim() == "" || Apellido.trim().lenght == 0 )
        {
            alert("El Apellido no es valido")
            return false;
            
        }
        if (Edad == "" || Edad.lenght == 0 || isNaN(Edad))
        {
            alert("La edad no es valida")
            return false;
            
        }

        return false;


    });
    let Vaciar = this.document.querySelector("#Vaciar");
    Vaciar = document.addEventListener('click',function(){
        let Nombre = document.querySelector('#Nombre');
        let Apellido = document.querySelector('#Apellido');
        let Edad = parseInt(document.querySelector('#Edad'));
        let Empresa = document.querySelector('#Empresa');

        Nombre.value = "";
        Apellido.value = "";
        Edad.value = "";
        Empresa.value = "";
    });
});