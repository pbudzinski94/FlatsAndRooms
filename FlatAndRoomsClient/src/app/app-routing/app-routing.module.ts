import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginScreenComponent } from '../login-screen/login-screen.component';
import { MainTableComponent } from '../main-table/main-table.component';
import { DetailsComponent } from '../details/details.component';
import { AdvertismentCreatorComponent } from '../advertisment-creator/advertisment-creator.component';

const routes: Routes = [
  { path: 'login', component: LoginScreenComponent},
  { path: 'search', component: MainTableComponent},
  { path: 'details/:id', component: DetailsComponent},
  { path: 'add', component: AdvertismentCreatorComponent}
];
@NgModule({
  exports: [
    RouterModule,
  ],
  imports: [
    CommonModule,
    RouterModule.forRoot(
      routes
    )
  ],
  declarations: []
})
export class AppRoutingModule { }
