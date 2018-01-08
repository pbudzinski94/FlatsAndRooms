import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss']
})
export class DetailsComponent implements OnInit {
  adv: AdvDetails;
  id: string;
  private sub: any;
  constructor(private route: ActivatedRoute, private http: HttpClient) { }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      this.id = params['id'];
      this.http.get<AdvDetails>('http://localhost:4200/api/AdvDetails/' + this.id).subscribe(d =>
        this.adv = d
      );
    }
    );
  }

}

export class AdvDetails {
  description: string;
  phone: string;
  email: string;
  addDate: Date;
  address: string;
  prize: number;
  constructor(description, phone, email, addDate, address, prize){
    this.addDate = addDate;
    this.address = address;
    this.description = description;
    this.email = email;
    this.phone = phone;
    this.prize = prize;
  }
}
