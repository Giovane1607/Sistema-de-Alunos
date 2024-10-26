import { Component, OnInit } from '@angular/core';
import { RoomService } from 'src/app/services/room.service';

@Component({
    selector: 'app-admin',
    templateUrl: './admin.component.html',
    styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {
    rooms: any[] = [];

    constructor(private roomService: RoomService) {}

    ngOnInit(): void {
        this.loadRooms();
    }

    loadRooms(): void {
        this.roomService.getRooms().subscribe((data: any[]) => {
            this.rooms = data;
        });
    }

    cancelReservation(roomId: number): void {
        this.roomService.cancelReservation(roomId).subscribe(() => {
            this.loadRooms();
        });
    }
}
