import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';


import { CartService } from '../service/cart.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {
  product;
  productId;


  constructor(private route: ActivatedRoute, private cartService: CartService) { }

  ngOnInit() {
     this.productId = this.route.snapshot.params['productId'];
    this.cartService.getCar(this.productId).subscribe(data=>{
      this.product = data;
    });
  }

  addToCart(product) {
    window.alert('Your product has been added to the cart!');
    this.cartService.addToCart(product);
  }
  

}