function SetCookieD(cookieName,cookieValue,nbrDays) {
	var today = new Date();
	var expire = new Date();
	if (nbrDays==null || nbrDays==0) nbrDays=1;
	expire.setTime(today.getTime() + 3600000*24*nDays);
	document.cookie = cookieName+"="+escape(cookieValue)
					  + ";expires="+expire.toGMTString();
}

function setCookieS(cname, cvalue, nbrSec) {
    var d = new Date();
    d.setTime(d.getTime() + (nbrSec*1000));
    var expires = "expires="+d.toUTCString();
    document.cookie = cname + "=" + cvalue + "; " + expires;
}

function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for(var i=0; i<ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0)==' ') c = c.substring(1);
        if (c.indexOf(name) == 0) return c.substring(name.length, c.length);
    }
    return "";
}

