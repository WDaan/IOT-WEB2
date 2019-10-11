<!DOCTYPE html>
<html>

<head>
    <title>Bakkerij De Korenbloem</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link rel="stylesheet" type="text/css" href="css/myStyle.css">
    <style>
        @import url("css/extraSmall.css") screen and (max-width: 450px);
        @import url("css/small.css") screen and (max-width: 600px);
        @import url("css/medium.css") screen and (max-width: 1000px);
    </style>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="scripts/myScript.js"></script>
    <script src="scripts/modernizrMediaQueries.js"></script>
</head>

<body>
    <div id="titleBar">
        <a href="index.php">
            <img src="images/brood.png" alt="brood">
            <span>Bakkerij </span><span id="dkb">De Korenbloem</span>
        </a>
    </div>

    <nav>
        <div id="menuButton">
            <img src="images/menu-button-of-three-horizontal-lines.svg" alt="menu button">
        </div>

        <a href="index.php?request=home" class="navField">
            <div>Home</div>
        </a>

        <a href="index.php?request=home" class="navField">
            <div>Bakkerij</div>
        </a>

        <a href="index.php?request=home" class="navField">
            <div>Personeel</div>
        </a>

        <a href="index.php?request=home" class="navField">
            <div>Kalender</div>
        </a>

        <a href="index.php?request=home" class="navField">
            <div>Bestellingen</div>
        </a>

        <a href="index.php?request=home" class="navField">
            <div>Contact</div>
        </a>

        <div style="clear:both"></div>
    </nav>

    <article>
        <?php
        include("home.php");
        ?>
    </article>

    <footer>
        <ul>
            <li id="footerName">&copy; Bakkerij De Korenbloem</li>
            <li><a href="http://www.vives.be" target="_blank">Webdesign: Vives.be</a></li>
        </ul>
        <div style="clear:both;"></div>
    </footer>
</body>

</html>