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
        
//선박정보
        $id = $_GET["shipid"];
        $data = $_GET["data"];
        $num = $_GET["loadingarm_num"];
        

        $query = "INSERT INTO ship_information(t_shipid,t_date,loadingarm_num) VALUES('$id','$data','$num')";
        mysqli_query($mysqli,$query);

        echo"</br>success!!!";
    }

    else{
        echo "error to connected";
    }

    //종료
    mysqli_close($mysqli);
    ?>