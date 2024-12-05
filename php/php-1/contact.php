<?php
    session_start();
    $title = "Контакты";
    require_once "blocks/header.php";   
?>
    
<h1 class = "mt-5">Контакты</h1>
<form action="check_contact.php" method="post">
<input type="text" name="username" value="<?=$_SESSION['username']?>" placeholder="Введите имя" class="form-control"><br>
    <input type="email" name="email" value="<?=$_SESSION['useremail']?>" placeholder="Введите почту" class="form-control"><br>
    <input type="text" name="subject" value="<?=$_SESSION['subject']?>" placeholder="Тема сообщения" class="form-control"><br>
    <textarea name="message"  class="form-control" <?=$_SESSION['message']?>placeholder = "Ваше сообщение"></textarea>
    <input type="submit" value="Отправить" class="btn btn-success">
</form>

<?php
    require_once "blocks/footer.php";
?>