import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-advertisment-creator',
  templateUrl: './advertisment-creator.component.html',
  styleUrls: ['./advertisment-creator.component.scss']
})
export class AdvertismentCreatorComponent implements OnInit {
  city: string;
  postalCode: string;
  adv: AdvertismentToAdd = new AdvertismentToAdd();
  constructor(private http: HttpClient) {

  }

  ngOnInit() {
  }
  onChange() {
    this.adv.city = this.city + ' ' + this.postalCode;
  }
  AddEquipment() {
    this.adv.equipments.push(new EquipmentVM());
  }
  Send() {
    alert('I am here');
    this.http.post('api/Add/new', this.adv).subscribe(d => {
      console.log('its done');
    });
  }
}

export class AdvertismentToAdd {
  userId = 'e6b5bd6f-8814-43ab-29ea-08d52aa4e68d';
  roomsNumber: number;
  floor: number;
  prize: number;
  peopleNumber: number;
  address: string;
  city: string;
  type: ObjectToRentType;
  equipments: EquipmentVM[] = [];
}

export class EquipmentVM {
  name: string;
  description: string;
}

export enum ObjectToRentType {
  Flat, Room
}
