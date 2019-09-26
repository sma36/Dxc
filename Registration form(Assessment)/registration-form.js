var flag =0;
function userVal() {
    var user = document.getElementById('user').value
    var l=user.length

    if(l<5 || l>12){
        alert('User Id length must be between 5 and 12')
        flag =0;
    }else{flag=1;}
   
}
function val_pass(){
    var p = document.getElementById('password').value
    var l=p.length

    if(l<7 || l>12){
        alert('Password length must be between 7 and 12')
        flag =0;

    }else{flag=1;}
  

}

function confirm_pass(){
    var p = document.getElementById('password').value
    var cp = document.getElementById('confirm_password').value

    if (p != cp) {
        alert('Passwords do no match')
        flag =0;

    } else{flag=1;}

}
function val_zip() {
    var pat = /^([0-9]{4,10})$/;
    var mob = document.getElementById('zipcode').value
    if (pat.test(mob) == false) 
    {
        alert('Invalid Zipcode');
        flag =0;

         
    }else{flag=1;}
}

function val_name(){
    var name = document.getElementById('name').value
    if (/[^a-zA-Z]/.test(name))
    {
        alert('Enter valid name')
        flag =0;

    }else{flag=1;}
    
}
function val_email() {
    var email = document.getElementById('email').value

    var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
           
            if (reg.test(email) == false) 
            {
                alert('Invalid Email Address');
                flag =0;
               
            }else{flag=1;}
            
}

function val_date(){
    var d = document.getElementById('date').value
    var dd = new Date(d).getTime()
    var today = new Date().getTime()
    var x =(today-dd)/(1000*60*60*24*365)
    if (x<18) {
        alert('User must beabove 18!')
        flag =0;

    }   else{flag=1;}
}

function val_checkbox(){
    var chkd = document.FC.c1.checked || document.FC.c2.checked
   
    if (!chkd == true){
        alert ("please check a checkbox")
        flag =0;

    }    else{flag=1;}
}
function end() {
    if (flag == 1) {
        alert('All fields are correct!!!')
    }
}