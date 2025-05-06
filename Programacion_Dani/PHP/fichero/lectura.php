<?php
$handle = fopen("HojaCalculo.csv", "r");
if ($handle) {
    while (($line = fgets($handle)) !== false) {

        // Split the line into an array using the comma as a delimiter
        $data = explode(";", $line);


        printf("<p>Vendedor: %s / %s(%s): %s</p>", $data[0], $data[2], $data[1], $data[3]);
    }

    fclose($handle);
}

?>