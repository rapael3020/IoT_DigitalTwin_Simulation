<?php
$host = '';
$user = 'test';
$password = '';
$database_name = '';
$host = '3306';
 
$conn = new mysqli($host, $user, $password, $database_name, $host); //DB정보

if($conn){
    echo "MySQL 접속 성공"; //연결됐을시
}else{
    echo "MySQL 접속 실패"; //실패시
}
?>
