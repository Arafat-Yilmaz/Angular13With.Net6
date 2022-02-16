import { Component } from '@angular/core';
import { CartService } from '../service/cart.service';


@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent {
  products;
  constructor(private service:CartService) {}
  ngOnInit() {
    this.service.getCars()
      .subscribe(response => {
        this.products = response;
      });
}

  
 
}
