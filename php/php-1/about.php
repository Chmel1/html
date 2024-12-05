<?php
    session_start();
    $title = "Про нас";
    require_once "blocks/header.php";
?>
<div class = "container mt-2">
<h1>Про нас</h1>
<form action="/check_get.php" method="get">
    <input type="text" name="username" placeholder="Введите имя" class="form-control"><br>
    <input type="text" name="email" placeholder="Введите почту" class="form-control"><br>
    <input type="password" name="password" placeholder="Введите пароль" class="form-control"><br>
    <textarea name="message"  class="form-control" placeholder = "Введите текст"></textarea>
    <input type="submit" value="Отправить" class="btn btn-success">
</form>
</div>

<?php
    require_once "blocks/footer.php";
?>