﻿< !DOCTYPE html >
< html lang = "vỉ" >
< head >
    < meta charset = "UTF-8" >
    < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
    < title > Đăng Ký thông tin khách hàng</title>
    <link rel="stylesheet" href="style1.css">
    <link href="~/Content/style1.css" rel="stylesheet" />
</head>
<body>
    <header>
        <h2 class= "logo" > Logo </ h2 >
        < nav class= "navigation" >
            < a href = "DoAn-NoiThat.html" > Home </ a >
            < a href = "Sofa.html" > Sofa cao cấp</a>
            <a href = "SOFAogoc.html" > Sofa góc cao cấp</a>
            <a href = "combogngu.html" > Combo giường ngủ</a>
            <button class= "btnLogin-popup" > Login </ button >
        </ nav >
    </ header >

    < div class= "wrapper" >
        < span class= "icon-close" > &#10539;</span>

        < div class= "form-box login" >
            < h2 > Login </ h2 >
            < form action = "#" >
                < div class= "input-box" >
                    < span class= "icon" ></ span >
                    < input type = "email" required >
                    < label > Email </ label >
                </ div >
                < div class= "input-box" >
                    < span class= "icon" ></ span >
                    < input type = "password" required >
                    < label > Password </ label >
                </ div >
                < div class= "remember-forgot" >
                    < label >< input type = "checkbox" > Remember me </ label >
                    < a href = "#" > Forgot Password ?</ a >
                </ div >
                < button type = "submit" class= "btn" > Login </ button >
                < div class= "login-register" >
                    < p > Don't have an account?<a href="#" class="register-link">Register</a></p>
                </ div >
            </ form >
        </ div >


        < div class= "form-box register" >
            < h2 > Registration </ h2 >
            < form action = "#" >
                < div class= "input-box" >
                    < span class= "icon" ></ span >
                    < input type = "text" required >
                    < label > Username </ label >
                </ div >
                < div class= "input-box" >
                    < span class= "icon" ></ span >
                    < input type = "email" required >
                    < label > Email </ label >
                </ div >
                < div class= "input-box" >
                    < span class= "icon" ></ span >
                    < input type = "password" required >
                    < label > Password </ label >
                </ div >
                < div class= "remember-forgot" >
                    < label >< input type = "checkbox" > Agree to the term & conditions </label>
                </div>
                <button type="submit" class= "btn" > Register </ button >
                < div class= "login-register" >
                    < p > Already have an account?<a href="#" class= "login-link" > Login </ a ></ p >
                </ div >
            </ form >
        </ div >
    </ div >

    < script src = "script.js" ></ script >


</ body >
</ html >
