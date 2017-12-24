<?php include('form_process.php'); ?>
<link rel="stylesheet" href="form.css" type="text/css">
<head>
    <title>WallDefense.com</title>
</head>
<body>
    <header>
    <nav>
    <h1>WallDefense.com</h1>
        <ul>
            <li><a href = "index.html" class = "web_button">Home</a></li>
            <li><a href = "aboutGame.html" class = "web_button">About The Game</a></li>
            <li><a href = "media.html" class = "web_button">Media</a></li>
            <li><a href = "form.php" class = "web_button">Contact Us</a></li>
        </ul>
    </nav>
    </header>
</body>
<div class="container">  
    <form id="contact" action="<?= htmlspecialchars($_SERVER["PHP_SELF"]) ?>" method="post">
        <h3>Contact</h3>
        <h4>Contact us today, and get reply with in 24 hours!</h4>
        <fieldset>
            <input placeholder="Your name" type="text" name="name" value="<?= $name ?>" tabindex="1" autofocus>
            <span class="error"><?= $name_error ?></span>
        </fieldset>
        <fieldset>
            <input placeholder="Your Email Address" type="text" name="email" value="<?= $email ?>" tabindex="2">
            <span class="error"><?= $email_error ?></span>
        </fieldset>
        <fieldset>
            <input placeholder="Your Phone Number" type="text" name="phone" value="<?= $phone ?>" tabindex="3">
            <span class="error"><?= $phone_error ?></span>
        </fieldset>
        <fieldset>
            <input placeholder="Your Web Site starts with http://" type="text" name="url" value="<?= $url ?>" tabindex="4" >
            <span class="error"><?= $url_error ?></span>
        </fieldset>
        <fieldset>
        <textarea value="<?= $message ?>" name="message" tabindex="5">
        </textarea>
        </fieldset>
        <fieldset>
            <button name="submit" type="submit" id="contact-submit" data-submit="...Sending">Submit</button>
        </fieldset>
        <div class="success"><?= $success ?></div>
    </form>
</div>
