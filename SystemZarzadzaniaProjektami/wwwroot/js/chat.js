"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    var date = document.createElement("a");
    date.textContent = `${new Date().toLocaleTimeString()}`;
    date.style.color = "gray";
    var strong = document.createElement("strong");
    strong.textContent = ` ${user}: `;
    strong.style.color = "red";
    var msg = document.createElement("a");
    msg.textContent = `${message}`;
    li.appendChild(date);
    li.appendChild(strong);
    li.appendChild(msg);
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value.trim();

    document.getElementById("messageInput").value = "";
    if (message == "") return 0;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

document.getElementById("messageInput").addEventListener("keypress", function (event) {
    if (event.key === "Enter" || event.keyCode === 13 || event.which === 13) {
        event.preventDefault();
        document.getElementById("sendButton").click();
        return false;
    }
});