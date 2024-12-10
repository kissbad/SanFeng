//设置cookie
function setCookie(name, value) {
    var Hour = 0.5;
    var exp = new Date();
    exp.setTime(exp.getTime() + Hour * 60 * 60 * 1000);
    document.cookie = name + "=" + encodeURI(value) + ";expires=" + exp.toGMTString();
}

//读取cookie
function getCookie(name) {
    var arr, reg = new RegExp("(^| )" + name + "=([^;]*)(;|$)");
    if (arr = document.cookie.match(reg))
        return decodeURI(arr[2]);
    else
        return null;
}
//删除cookie
function delCookie(name) {
    var exp = new Date();
    exp.setTime(exp.getTime() - 1);
    var cval = getCookie(name);
    if (cval != null) {
        document.cookie = name + "=" + cval + ";expires=" + exp.toGMTString();
        document.cookie = name + "=" + cval + ";path=/;domain=" + document.domain + ";expires=" + exp.toGMTString();
    }
        
}
