export class User{
    static nextId: number = 0;

    constructor(
    public id: number = 0,
    public title: string = '',
    public firstName: string = '', 
    public lastName: string = '',
    public email: string = '',
    public role: string = '',
    public passwordHash: string = '')
    {
        this.id = id ? id : User.nextId++;
    }
}