import { BrowserModule } from '@angular/platform-browser';
import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { VisualizerComponent } from './modules/visualizer/visualizer.component';
import { VisualizerModule } from './modules/visualizer/visualizer.module';
import { MessagesListModule } from './modules/messages-list/messages-list.module';
import { MessagesListComponent } from './modules/messages-list/messages-list.component';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { ToastrModule } from 'ngx-toastr';
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    VisualizerModule,
    MessagesListModule,
    ToastrModule.forRoot(),
    MDBBootstrapModule.forRoot(),
    RouterModule.forRoot([
      { path: '', component: VisualizerComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'messages', component: MessagesListComponent },
    ])
  ],
  schemas: [NO_ERRORS_SCHEMA],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
