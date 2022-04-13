<?php
header("Content-Type: text/html;charset=UTF-8");

$host = '3.34.94.167';
$user = '';
$pw = '';
$dbname = '';
$host = '3306';
$mysqli = new mysqli($host, $user, $pw, $dbname, $host); //정보

//데이터정보가져오기
    if($mysqli){
        echo "MySQL successfully connected!<br/>";
        //x,y,z 관절값 받아오기

        $num = $_GET["indexnumber"];
        $sensor4 = $_GET["sensor4"];
        $sensor5 = $_GET["sensor5"];
        $sensor6 = $_GET["sensor6"];

        $query = "INSERT INTO simulation(i_1,s_x1,s_y1,s_z1) VALUES('$num','$sensor4','$sensor5','$sensor6')";
        mysqli_query($mysqli,$query);

        echo"</br>success!!!";
    }

    else{
        echo "error to connected";
    }
//종료
    mysqli_close($mysqli);
    ?>