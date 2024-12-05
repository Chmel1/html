class User{
    static userCount = 0;

    constructor(username,password){
        this.username = username;
        this.password = password;
        User.userCount++
    }
}


console.log(User.userCount);
