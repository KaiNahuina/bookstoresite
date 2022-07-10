function validateContactForm() {
    if (document.ContactForm.name.value == "") {
        alert("Please provide your name.");
        document.ContactForm.name.focus();
        return false;
    }
    if (document.ContactForm.email.value == "") {
        alert("Please provide your email.");
        document.ContactForm.email.focus();
        return false;
    }
    if (document.ContactForm.phone.value == "") {
        alert("Please provide your phone number.");
        document.ContactForm.phone.focus();
        return false;
    }
    if (document.ContactForm.reason.value == "") {
        alert("Please provide your reason for contact.");
        document.ContactForm.reason.focus();
        return false;
    }

    return (true);

}


function validateCreateForm() {
    if (document.CreateForm.title.value == "") {
        alert("Please provide the title.");
        document.CreateForm.title.focus();
        return false;
    }
    if (document.CreateForm.author.value == "") {
        alert("Please provide the author.");
        document.CreateForm.author.focus();
        return false;
    }
    if (document.CreateForm.price.value == "") {
        alert("Please provide the price.");
        document.CreateForm.price.focus();
        return false;
    }
    if (document.CreateForm.description.value == "") {
        alert("Please provide the description.");
        document.CreateForm.description.focus();
        return false;
    }
    return (true);
}