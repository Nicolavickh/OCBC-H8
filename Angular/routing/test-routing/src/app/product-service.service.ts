import { Injectable } from '@angular/core';

import { Product } from "./Models/product";
import { PRODUCTS } from "./Models/mock-product";
import { Observable, of } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class ProductServiceService {

  constructor() { }

  getProducts(): Observable<Product[]>{
    const products = of(PRODUCTS);

    console.log("Fetched list of prodcuts...");
    return products;
  }
}
