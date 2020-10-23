function Property(
  name,
  email,
  price,
  title,
  propertyType,
  propertyStories,
  propertySize,
  bedrooms,
  bathrooms,
  parking,
  imageUrl,
  otherDetails
) {
  this.name = name;
  this.email = email;
  this.title - title;
  this.price = price;
  this.propertyType = propertyType;
  this.propertyStories = propertyStories;
  this.propertySize = propertySize;
  this.bedrooms = bedrooms;
  this.bathrooms = bathrooms;
  this.parking = parking;
  this.imageUrl = imageUrl;
  this.otherDetails = otherDetails;
}

function saveProperty() {
  var name = $("#txtName").val();
  var email = $("#txtEmail").val();
  var title = $("#txtTitle").val();
  var price = parseFloat($("#txtPrice").val());
  var propertyType = $("#txtPropertyType").val();
  var propertyStories = parseInt($("#txtPropertyStories").val());
  var propertySize = parseInt($("#myRange").val());
  var bedrooms = parseInt($("#txtBedrooms").val());
  var bathrooms = parseInt($("#txtBathrooms").val());
  var parking = $("#inlineRadio1").is(":checked");
  var imageUrl = $("#txtImage").val();
  var otherDetails = $("#txtOtherDetails").val();
  var error = false;

  if (!name) {
    alert("Error, verify the Name.");
    error = true;
  }
  if (!email) {
    alert("Error, verify the email.");
    error = true;
  }
  if (!title) {
    alert("Error, verify the title.");
    error = true;
  }
  if (!price) {
    alert("Error, verify the price.");
    error = true;
  }
  if (!propertyType) {
    alert("Error, verify the property type.");
    error = true;
  }
  if (!propertyStories) {
    alert("Error, verify the property stories.");
    error = true;
  }
  if (!propertySize) {
    alert("Error, verify the property size.");
    error = true;
  }
  if (!bedrooms) {
    alert("Error, verify the bedrooms.");
    error = true;
  }
  if (!bathrooms) {
    alert("Error, verify the bathrooms.");
    error = true;
  }
  if (!parking) {
    alert("Error, verify the parking.");
    error = true;
  }
  if (error) {
    return;
  }

  var prop = new Property(
    name,
    email,
    price,
    title,
    propertyType,
    propertyStories,
    propertySize,
    bedrooms,
    bathrooms,
    parking,
    imageUrl,
    otherDetails
  );

  console.log(prop);

  $.ajax({
    url: "/catalog/SaveProperty",
    type: "POST",
    data: JSON.stringify(prop),
    contentType: "application/json",
    success: (res) => {
      console.log(res);
      $(".form-control").val("");
    },
    error: (details) => {
      console.log("Error", details);
    },
  });
}

function init() {
  console.log("Register Page");

  $("#btnSave").click(saveProperty);

  var slider = document.getElementById("myRange");
  var output = document.getElementById("demo");
  output.innerHTML = slider.value; // Display the default slider value

  // Update the current slider value (each time you drag the slider handle)
  slider.oninput = function () {
    output.innerHTML = this.value;
  };
}

window.onload = init;
