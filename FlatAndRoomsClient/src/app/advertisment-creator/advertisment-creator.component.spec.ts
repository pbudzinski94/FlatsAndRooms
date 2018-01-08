import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdvertismentCreatorComponent } from './advertisment-creator.component';

describe('AdvertismentCreatorComponent', () => {
  let component: AdvertismentCreatorComponent;
  let fixture: ComponentFixture<AdvertismentCreatorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdvertismentCreatorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdvertismentCreatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
