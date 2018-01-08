import { Component, OnInit } from '@angular/core';
import { AdvType } from '../adv-type.enum';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-main-table',
  templateUrl: './main-table.component.html',
  styleUrls: ['./main-table.component.scss']
})
export class MainTableComponent implements OnInit {
  ads: AdBasic[];
  Type = AdvType;
  constructor(private http: HttpClient) {

   }

  ngOnInit() {
    this.http.get<AdBasic[]>('http://localhost:4200/api/AdBasic/all').subscribe(d =>
    {
      this.ads = d;
      console.log(this.ads);
    }
    );
  }
  show(){
    alert(JSON.stringify(this.ads));
  }
}

export class AdBasic{
  id: string;
  title: string;
  prize: number;
  type: AdvType;
  addDate: Date;
  peopleNumber: Number;
  constructor(Title, Prize, Type, AddDate, PeopleNumber){
    this.title = Title;
    this.prize = Prize;
    this.type = Type;
    this.addDate = AddDate;
    this.peopleNumber = PeopleNumber;

  }
}
