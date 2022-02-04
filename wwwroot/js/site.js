// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


    var btn_up = document.querySelector('.btn_up');
    var btn_down = document.querySelector('.btn_down');

    function myFunction(elem){
        elem.classList.toggle('clicked');
    if(elem === btn_up){
        btn_down.classList.remove('clicked');
        }else{
        btn_up.classList.remove('clicked');
        }
    }

var post = document.getElementById("post");
post.addEventListener("click", function () {
    var commentBoxValue = document.getElementById("comment-box").value;

    var li = document.createElement("li");
    var text = document.createTextNode(commentBoxValue);
    li.appendChild(text);
    document.getElementById("unordered").appendChild(li);

});



    function remove()
    {
var element = document.getElementById("heading");
    element.remove();
}
