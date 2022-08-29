// window.addEventListener('load' , function () {
//     let btn = document.getElementById("showText");
//     btn.addEventListener("click", showOrHideText);

//     function showOrHideText() {
//        let paragraf = document.getElementsByTagName("p");
//        let myP = paragraf[0];
//        console.log(myP.classList.contains("hide"));

//         // so menuvanje na class
//        if (myP.classList.contains("hide")) {
//             myP.classList.remove("hide");
//             myP.classList.add("show");

//        }else{
//         myP.classList.add("hide");
//         myP.classList.remove("show");

//        }
//         // so menuvanje na css
//        if (myP.style.display == "none") {
//         myP.style.display = "block";
//        } else {
//         myP.style.display = "none";
//        }
//     }
// }, false);



$(document).ready(function () {
    $("p")[0].style.display = "none";

    $("#showText").click(function () {
        let paragraphs = $("p");
        let myP = paragraphs[0];

        if (myP.style.display == "none") {
            myP.style.display = "block";
        } else {
            myP.style.display = "none";
        }
    });
});