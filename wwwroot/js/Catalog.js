function fetchData() {
  $.ajax({
    url: "/catalog/getProperties",
    type: "GET",
    success: (data) => {
      console.log(data);
      for (let i = 0; i < data.length; i++) {
        displayProperty(data[i]);
      }
    },
    error: (details) => {
      console.log("Error", details);
    },
  });
}

function displayProperty(prop) {
  var syntax = `<div class='property' >
                    <img class='pimg' src="${prop.imageUrl}">
                    <h5>${prop.title}<h5>
                    <h5>${prop.propertySize} SqFt<h5>
                    <h5>$ ${prop.price}<h5>
                    <h5>Bedrooms: ${prop.bedrooms}<h5>
                    <h5>Bathrooms: ${prop.bathrooms}<h5>
                    <h5>Parking: ${prop.parking}<h5>

                </div>`;

  var container = $("#catalog-container");

  container.append(syntax);
}

function init() {
  console.log("Catalog Page");

  fetchData();
}

function testDelete() {
  var id = 1;
  $.ajax({
    url: "/catalog/DeleteProperty/" + id,
    type: "DELETE",
    data: id,
    contentType: "application/json",
    success: () => {
      console.log("deleted");
    },
    error: (details) => {
      console.log("Error", details);
    },
  });
}

window.onload = init;
