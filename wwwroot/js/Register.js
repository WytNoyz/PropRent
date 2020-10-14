

function Property(name, email, price, propertyType, propertyStories, propertySize, bedrooms, bathrooms, parking, otherDetails){
    this.name = name;
    this.email = email;
    this.price = price;
    this.propertyType = propertyType;
    this.propertyStories = propertyStories;
    this.propertySize = propertySize;
    this.bedrooms = bedrooms;
    this.bathrooms = bathrooms;
    this.parking = parking;
    this.otherDetails = otherDetails;
}

function saveProperty(){
    var name = $("#txtName").val();
    var email = $("#txtEmail").val();
    var price = $("txtPrice").val();
    var propertyType = $("#txtPropertyType").val();
    var propertyStories = parseInt($("#txtPropertyStories").val());
    var propertySize = $("#myRange").val();
    var bedrooms = parseInt($("#txtBedrooms").val());
    var bathrooms = parseInt($("#txtBathrooms").val());
    var parking = $("#radio_0").is(":checked");
    var otherDetails = $("#txtOtherDetails").val();

    if(!name) {
        alert("Error, verify the Name.");
    }
    if(!email) {
        alert("Error, verify the email.");
    }
    if(!price) {
        alert("Error, verify the price.");
    }
    if(!propertyType) {
        alert("Error, verify the property type.");
    }
    if(!propertyStories) {
        alert("Error, verify the property stories.");
    }
    if(!propertySize) {
        alert("Error, verify the property size.");
    }
    if(!bedrooms) {
        alert("Error, verify the bedrooms.");
    }
    if(!bathrooms) {
        alert("Error, verify the bathrooms.");
    }
    if(!parking) {
        alert("Error, verify the parking.");
    }
    
    
    var prop = new Property(name, email, price, propertyType, propertyStories, propertySize, bedrooms, bathrooms, parking, otherDetails);
    
    console.log(prop);
    
    
    $.ajax({
        url: "/catalog/saveProperty",
        type: "POST",
        data: JSON.stringify(prop),
        contentType: "application/json",
        success: (res) => {
            console.log(res);
            $(".form-control").val('');
        },
        error: (details) => {
            console.log("Error", details);
        }
    });




}

function init() {
    console.log("Register Page")
    
    $("btnSave").click(saveProperty);

    var slider = document.getElementById("myRange");
    var output = document.getElementById("demo");
    output.innerHTML = slider.value; // Display the default slider value

    // Update the current slider value (each time you drag the slider handle)
    slider.oninput = function () {
        output.innerHTML = this.value;
    }
}




window.onload = init;