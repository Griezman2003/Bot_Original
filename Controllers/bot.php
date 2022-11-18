<?php
error_reporting(0);
header("Cache-Control: no-cache, must-revalidate"); // HTTP/1.1
header("Expires: Sat, 26 Jul 1997 05:00:00 GMT"); // Date in the past
header("Pragma: no-cache");

$token= "";

$data = file_get_contents("php://input");
$update = json_decode($data,true);
$message = $update['message'];

$id = $message["from"]["id"];
$name = $message["from"]["first_name"];
$text = $message["text"];


/*
if(isset($text) &&  $text =='/start')
{
	$respuesta = "Hola ".$name." -- Bienvenido 😜 a mi Último BOT";
	sendMessage($id,$respuesta,$token);
}

else if(isset($text) &&  $text =='/help')
{

	$respuesta = "Este es un Robot de Prueba para Telegram Hecho 100% en PHP, sin librerias Externas en un solo archivo\n\n".
	'Y funciona en cualquier hosting  asi sea barato, solo debe tener  HTTPS.';
	sendMessage($id,$respuesta,$token);
}

else if(isset($text) &&  $text =='uptime')
{
	$res = shell_exec("uptime");
	$respuesta = $res;

	sendMessage($id,$respuesta,$token);
}
*/

if(isset($text) &&  $text =='❌ CANCELAR')
{

$keyboard= [
	['Opción 1','Opción 2'],
	['❌ CANCELAR']
];

	$key = array('one_time_keyboard' => true,'resize_keyboard' => true,'keyboard' => $keyboard);
	$k=json_encode($key);


	$respuesta = "USTED HA CANCELADO";
	sendMessage($id,$respuesta,$token);


	die();
}





$keyboard= [
	['📌100','200','300'],
	['400','500'],
	['❌ CANCELAR'],
];

$key = array('one_time_keyboard' => true,'resize_keyboard' => true,'keyboard' => $keyboard);
$k=json_encode($key);


	$respuesta =' Hola';
    sendMessage($id,$respuesta,$token,$k);











function sendMessage($chatID, $messaggio, $token,&$k = ''){
    $url = "https://api.telegram.org/" . $token . "/sendMessage?disable_web_page_preview=false&parse_mode=HTML&chat_id=" . $chatID;

	if(isset($k)) {
		$url = $url."&reply_markup=".$k; 
		}

    $url = $url."&text=" . urlencode($messaggio);
    $ch = curl_init();
    $optArray = array(
            CURLOPT_URL => $url,
            CURLOPT_RETURNTRANSFER => true
    );
    curl_setopt_array($ch, $optArray);
    $result = curl_exec($ch);
    curl_close($ch);
}
?>