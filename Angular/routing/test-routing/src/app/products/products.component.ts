import { Component, OnInit } from '@angular/core';
import { Product } from "../Models/product";
import { ProductServiceService } from "../product-service.service";

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  products: Product[] = [];

  constructor(private productService: ProductServiceService) { }

  ngOnInit(): void {
    this.getProducts();
  }

  getProducts(){
    this.productService.getProducts().subscribe(products => this.products = products);
  }

}
