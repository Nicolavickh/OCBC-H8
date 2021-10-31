export class Country{
    static nextId = 1;

    constructor(
        public id:number,
        public name: string,
        public capital: string,
        public area: number,
        public population: number, 
        public gdp: number,
        public currency: string){
            this.id = id ? id : Country.nextId++;
        }
}