import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CartService {
private url = 'https://localhost:7072/Warehouse/warehouse';
  items : String[]=[];
  warehouse=[];

  constructor(private http: HttpClient) { }

  addToCart(product) {
    this.items.push(product);
  }

  getItems() {
    return this.items;
  }
  
  getCars(){
    return this.http.get(this.url);
  }
  getCar(id:number){
    return this.http.get(this.url +'/'+ id);
  }
  }