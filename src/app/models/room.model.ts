export class Room {
    id: number;
    number: string;
    type: string;
    price: number;
    isAvailable: boolean;

    constructor(id: number, number: string, type: string, price: number, isAvailable: boolean) {
        this.id = id;
        this.number = number;
        this.type = type;
        this.price = price;
        this.isAvailable = isAvailable;
    }
}