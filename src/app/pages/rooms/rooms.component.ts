import { Component } from '@angular/core';

interface Room {
  title: string;
  description: string;
  price: string;
  imageUrl: string; 
}

@Component({
  selector: 'app-rooms',
  templateUrl: './rooms.component.html',
  styleUrls: ['./rooms.component.css'] 
})
export class RoomsComponent {
  rooms: Room[] = [
    {
      title: 'Quarto Deluxe',
      description: 'Um quarto luxuoso com cama king-size e vista para o mar.',
      price: 'R$ 300,00',
      imageUrl: 'assets/images/luxo.webp' 
    },
    {
      title: 'Quarto de casal',
      description: 'Um quarto confortável com cama de casal.',
      price: 'R$ 200,00',
      imageUrl: 'assets/images/padrao.webp' 
    },
    {
      title: 'Quarto presidencial',
      description: 'Um quarto simples e econômico para estadias curtas.',
      price: 'R$ 150,00',
      imageUrl: 'assets/images/presidencial.webp' 
    }
  ];
}
