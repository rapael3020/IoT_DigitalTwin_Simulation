<?php
$host = '';
$user = '';
$password = '';
$database_name = 'LoadingArm'; // 정보
 
$conn = new mysqli($host, $user, $password, $database_name); //db연결
$query = "select n_id, n_name, n_num, n_phone, n_addr, n_pw from nomal_user"; //가져올 쿼리

$result = mysqli_query($conn, $query); //결과쿼리

//mysql에서 꺼내서 화면에 나열
while($data = mysqli_fetch_row($result)){
   print_r($data);
   echo '<br>';
}
?>