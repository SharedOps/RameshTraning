$(document).ready(function () {


   

    getFormData();

    $("#btnSubmitClick").click(function () {
        getFormData();
    });
});





function getFormData() {

    $("#currentDate").val(new Date());
    var firstName = $("#first_name").val();
    var lastName = $("#last_name").val();


    if (firstName !== "" && lastName !== "") {
        $("#user").text(firstName + " " + lastName);
    } else {
        $("#user").text("User not found");
    }

}