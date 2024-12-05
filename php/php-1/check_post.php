<?php
$name = $_POST['username'];
$email = $_POST['email'];
$pass = $_POST['password'];

if (trim($name) == '')
{
    echo 'Вы не ввели Имя';
}
else if (strlen(trim( $name)) <= 1)
{
    echo 'Такого имени не существует';
}

else
{
    /* $_POST['password'] = password_hash($pass, PASSWORD_DEFAULT );
    echo "<h1>Все данные</h1>";
    foreach ($_POST as $key => $value)
    {
        echo "<p>$key:$value</p>";
    } */

    header('Location: /index.php');
    exit;
}