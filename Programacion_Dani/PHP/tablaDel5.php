<?php
    echo "<table border='1' cellpadding='5' cellspacing='0'>";
    echo "<tr>";
    echo "<th>Operacion</th>";
    echo "<th>Resultado</th>";
    echo "</tr>";
    for($i = 0 ; $i<=10; $i++){
        $r = 5*$i;
        echo "<tr>";
        echo "<td> $i x 5</td>";
        echo "<td> $r </td>";
        echo "</tr>";
    }

    echo "</table>"
?>