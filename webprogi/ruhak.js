//alert("ada")

$.ajax(
    {
        url:"https://fakestoreapi.com/products",
        dataType:'json',
        success: function(data)
        {
            console.log(data);
            data.forEach(product => 
                {
                    console.log(product)
                    let kartya =termekKartya(product.id,product.title,product.image,product.description);
                    $("#termekLista").append(kartya);
                }
            );
        }
    });

    function termekKartya(id,nev,kepurl,leiras,)
    {
              let keret =jQuery("<div>");
              keret.prop("class","card");
              keret.addClass("col-3")
              keret.on("click",function(){
                //alert("buzi");
                
                $.ajax(
                    {
                        url:"https://fakestoreapi.com/products/"+id,
                        dataType:'json',
                        success: function(data)
                        {
                            //console.log(data)
                            $("#termekTitle").html(data.title);
                            $("#termekAr").html("Ár: " + data.price + "€");
                            $("#termekLeiras").html("Leírás: " + data.description);
                            $("#termekKategoria").html("Kategória: " + data.category);
              
                            let kep = jQuery("<img>");
                            kep.prop("src", data.image);
                            $("#termekKep").append(kep);
              
                            $("#termekErtekeles").html("Értékelés: Work in progress");



                            togglePopup();
                        }
                        

                       /* <div id="termekAdat">
                <h3>Title</h3>
                <div>Ár: price</div>
                <p>Leírás: description</p>
                <div>Kategória: category</div>
                <img src="" >
                <div>Értékelés: rate(count darab)</div>
                 </div>
                */




                        
                    });


              });

              let kep=jQuery("<img>");
              kep.prop("src",kepurl);
              kep.prop("class","card-img-top");
              kep.prop("alt",nev)

              let neve =jQuery("<h5>");
              neve.html(nev);
              neve.prop("class","card-title");

              let leir=jQuery("<p>");
              leir.html(leiras);
              leir.prop("class","card-text");

              let cardBody=jQuery("<div>");
              cardBody.prop("class","card-body")

              cardBody.append(neve);
              cardBody.append(leir);
              keret.append(kep);
              keret.append(cardBody);             
              
              return keret;
    }
    // Function to show and hide the popup
    function togglePopup() {
        $(".content").toggle();
    }



    
/*<div class="card" style="width: 18rem;">
<img src="..." class="card-img-top" alt="...">
<div class="card-body">
  <h5 class="card-title">Card title</h5>
  <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
  <a href="#" class="btn btn-primary">Go somewhere</a>
</div>
</div>
*/