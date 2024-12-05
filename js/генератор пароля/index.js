function generatePassword(passwordLength,includeLowercase,includeUppercase,includeNumbers,includesSymbols){
    const lowercaseChars = "qwertyuiopasdfghjklzxcvbnm" 
    const upperCaseChars = "QWERTYUIOPASDFGHJKLZXCVBNM";
    const numberChars = "0123456789"
    const symbols = "!@#$%&"

    let allowedChars = ""
    let password = ""

    allowedChars += includeLowercase ? lowercaseChars : "";
    allowedChars += includeUppercase ? upperCaseChars : "";
    allowedChars += includeNumbers ? numberChars : "";
    allowedChars += includesSymbols ? symbols : "";    

    if(passwordLength <=0){
        return "Пароль не может быть длиной меньше одного"
    }
    if (allowedChars.length === 0)
        {
            return "Должен быть включен хоть один метод генерации"
        }

        for(let i = 0;i< passwordLength; i++)
        {
            const randomIndex = Math.floor(Math.random()  * allowedChars.length)
            password += allowedChars[randomIndex];
        }

    return password;
}


const passwordLength = 20;
const includeLowercase = true;
const includeUppercase = true;
const includeNumbers = true;
const includesSymbols = true;

const password = generatePassword(  passwordLength,
                                    includeLowercase,
                                    includeUppercase,
                                    includeNumbers,
                                    includesSymbols)

console.log(`Cгенерированный пароль: ${password}`);
