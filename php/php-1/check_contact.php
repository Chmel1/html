<?php
    session_start();

    $user_name=htmlspecialchars(trim($_POST['username']));
    $user_email=htmlspecialchars(trim($_POST['email']));
    $user_subject =htmlspecialchars(trim($_POST['subject']));
    $user_message = htmlspecialchars(trim($_POST['message']));

    $_SESSION['user_name'] = $user_name;
    $_SESSION['user_email'] = $user_email;
    $_SESSION['user_subject'] = $user_subject;
    $_SESSION['user_message'] = $user_message;

    
