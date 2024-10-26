import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Room } from '../models/room.model';

@Injectable({
    providedIn: 'root'
})
export class RoomService {
    private apiUrl = '';

    constructor(private http: HttpClient) {}

    getRooms(): Observable<any[]> {
        return this.http.get<any[]>(`${this.apiUrl}/rooms`);
    }

    cancelReservation(roomId: number): Observable<any> {
        return this.http.delete<any>(`${this.apiUrl}/rooms/${roomId}`);
    }
}