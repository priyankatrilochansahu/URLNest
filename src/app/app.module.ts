import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';

// Import HttpClientModule for HTTP requests
import { HttpClientModule } from '@angular/common/http';

// Import your components
import { SearchQueryComponent } from './search-query/search-query.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';

// Import the routing module
import { AppRoutingModule } from './app-routing.module';
import { NavbarComponent } from './navbar/navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    SearchQueryComponent,
    AboutComponent,
    ContactComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    AppRoutingModule  // <-- Add the routing module here
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

