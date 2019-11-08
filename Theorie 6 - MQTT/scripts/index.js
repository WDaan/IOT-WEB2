let creds = {
  host: "farmer.cloudmqtt.com",
  port: "34522",
  clientID: `${Math.floor(Math.random() * 10001)}`,
  user: "daan",
  pass: "daan"
};

let client;

window.onload = Init;

function Init() {
  client = new Paho.MQTT.Client(creds.host, Number(creds.port), String(creds.clientID));

  // Event onMessageArrived, koppelen met functie onMessageArrived.
  client.onMessageArrived = onMessageArrived;

  // Verbinding maken met de broker.
  client.connect({
    onSuccess: onConnected,
    userName: creds.user,
    password: creds.pass,
    useSSL: true
  });

  // Klikken op de knop, koppelen met een actie...
  document
    .getElementById("btnSendMessage")
    .addEventListener("click", function() {
      message = new Paho.MQTT.Message(
        document.getElementById("tbxMessage").value
      );
      message.destinationName = "daan"; // Moet gelijk zijn aan 'topic'.
      client.send(message);
    });
}

function onConnected() {
  console.log("onConnected");
  client.subscribe("daan", {
    onSuccess: onSubscribed
  });
}

function onMessageArrived(message) {
  var currentTime = new Date();

  document.getElementById("divSubscription").innerHTML +=
    message.payloadString + " (" + currentTime.toLocaleTimeString() + ")<br>";
  console.log("onMessageArrived: " + message.payloadString);
}

function onSubscribed(invocationContext) {
  console.log("onSubscribed");
}
