import { FormBuilder } from '@angular/forms';
import { CartService } from '../service/cart.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {
  items;
  totalPrice=0;
  
  constructor(
    private cartService: CartService
  ) { }

  ngOnInit() {
    this.items = this.cartService.getItems();
    this.totalPrice=this.calculateTotalPrice();
  
  }
  calculateTotalPrice() {
    let eachPrice=0;
    this.items.forEach(element => {
      eachPrice +=element.price;
   });
    return eachPrice;
  }
  columnDefs = [
    { field: 'make' },
    { field: 'model' },
    { field: 'price' },
    {field:'year_model'},
    {field:'date_added'}
];
  
}