import { ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { TopBarComponent } from './top-bar/top-bar.component';
import { ProductListComponent } from './product-list/product-list.component';

import { ProductDetailsComponent } from './product-details/product-details.component';
import { CartService } from './service/cart.service';
import { CartComponent } from './cart/cart.component';
import { HttpClientModule } from '@angular/common/http';
import { AgGridModule } from 'ag-grid-angular';
import {ScrollingModule} from '@angular/cdk/scrolling';

@NgModule({
  imports: [
    BrowserModule,
    HttpClientModule,
    ScrollingModule,
    ReactiveFormsModule,AgGridModule.withComponents([]),
    RouterModule.forRoot([
      { path: '', component: ProductListComponent },
      { path: 'products/:productId', component: ProductDetailsComponent },
      { path: 'cart', component: CartComponent },
    ]),
  ],
  declarations: [
    AppComponent,
    TopBarComponent,
    ProductListComponent,

    ProductDetailsComponent,
    CartComponent,
  ],
  bootstrap: [AppComponent],
  providers: [CartService],
})
export class AppModule {}
