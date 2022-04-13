<?php
$host = '';
$user = '';
$password = '';
$database_name = ''; //정보
 
$conn = new mysqli($host, $user, $password, $database_name); //디비연결
$query = "select s_x1, s_y1, s_z1 from Simulation"; //꺼낼 테이블확인


$result = mysqli_query($conn, $query); //결과 쿼리

//mysql에서 꺼내어 화면에 나열
while($data = mysqli_fetch_row($result)){
   print_r($data);
   echo '<br>';
}
?>