function checkNullOrEmpty(element) {
    var tbVal=$(element).val()
    if (tbVal == "" || tbVal == null) {
        alert("this field cannot be empty, please enter a value")
    }
}