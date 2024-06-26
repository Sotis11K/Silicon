function formErrorHandler(element, validationResult) {
    let spanElement = document.querySelector(`[data-valmsg-for="${element.name}"]`);

    if (validationResult) {
        element.classList.remove('input-validation-error')
        spanElement.classList.remove('field-validation-error')
        spanElement.classList.add('field-validation-valid')
        spanElement.innerHTML = ""
    }
    else {
        element.classList.add('input-validation-error')
        spanElement.classList.add('field-validation-error')
        spanElement.classList.remove('field-validation-valid')
        spanElement.innerHTML = element.dataset.valRequired
    }

}

function compareValidator(value, compareValue) {
    if(value === compareValue){
        return true
    }
    return false;
}


function textValidator(element, minLength = 2) {

    if (element.value.length >= minLength) {
        formErrorHandler(element, true)
    }
    else {
        formErrorHandler(element, false)
    }


}

function emailValidator(element) {
    const regEx = /^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/;
    formErrorHandler(element, regEx.test(element.value))
}


function passwordlValidator(element) {
    if (element.dataset.valEqualtoOther !== undefined) {

        let password = document.getElementsByName(element.dataset.valEqualtoOther.replace('*', 'Form'))[0].value


        if (element.value === password) {
            formErrorHandler(element, true)
        }
        else {
            formErrorHandler(element, false)
        }




        

    }
    else {
        const regEx = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})/
        formErrorHandler(element, regEx.test(element.value))
    }

}


function checkboxValidator(element) {
    if (element.checked) {
        formErrorHandler(element, true)
    }
    else {
       formErrorHandler(element, false)
    }
}




let forms = document.querySelectorAll('form')
let inputs = forms[0].querySelectorAll('input')

inputs.forEach(input => {
    if (input.dataset.val === 'true') {

        if (input.type === 'checkbox') {
            input.addEventListener('change', (e) => {
                checkboxValidator(e.target);
            })
        }

        else {
            input.addEventListener('keyup', (e) => {
                switch (e.target.type) {
                    case 'text':
                        textValidator(e.target)
                        break;
                    case 'email':
                        emailValidator(e.target)
                        break;
                    case 'password':
                        passwordlValidator(e.target)
                        
                }
            })
        }



    }
})