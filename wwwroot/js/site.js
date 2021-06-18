// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//checkout button

var element = document.getElementById('submit-purchase');
if (typeof (element) != 'undefined' && element != null) //if the page doesn't have the registration then JS skips this code
{
    document.getElementById('submit-purchase').addEventListener('submit', () => {
        alert("Thank you for your purchase");
    });
}
