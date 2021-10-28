function deleteSpace(password){
    return password.replace(/\s/g, '');
}

function reverseString(password){
    return password.split("").reverse().join("");
}

function simpleEncrypt(password){
    password = password.replace(/a/g, 'b');
    password = password.replace(/A/g, 'B');
    password = password.replace(/i/g, 'j');
    password = password.replace(/I/g, 'J');
    password = password.replace(/u/g, 'v');
    password = password.replace(/U/g, 'V');
    password = password.replace(/e/g, 'f');
    password = password.replace(/E/g, 'F');
    password = password.replace(/o/g, 'p');
    password = password.replace(/O/g, 'P');
    return password;
}

let pw = "Test 1 2 3 AiUEo"

let encrypt = deleteSpace(pw);
encrypt = reverseString(encrypt);
encrypt = simpleEncrypt(encrypt);

console.log(encrypt);