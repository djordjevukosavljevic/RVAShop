
document.getElementById("submitButton").onclick = function () {
    var masterChoice = document.getElementById("masterCard");
    var visaChoice = document.getElementById("visaCard");
    var paypalChoice = document.getElementById("paypalCard");

    if (masterChoice.checked) {
        console.log("You are paying with MasterCard....");
    } else if (visaChoice.checked) {
        console.log("You are paying with Visa....");
    } else if (paypalChoice.checked) {
        console.log("You are paying with PayPal...");
    } else {
        console.log("You must choose a paying method...");
    }
}    

document.getElementById("verifyBtn").onclick = function () {
    var whateverString = "";
    var cardNumber = document.getElementById("cardNum").value;
    if (cardNumber == whateverString) {
        console.log("You must enter a NUMERIC VALUE");
    }
    else if (cardNumber >= 100000) {
        console.log("Card number is too high...");
    } else if (cardNumber <= 12) {
        console.log("Card number is too low....");
    } else {
        window.alert("Congrats, you just bought our product!");
    }
}