import { Component, OnInit } from '@angular/core';
import {Product} from "../../models/product.model";
import {StoreService} from '../../services/store.service'

//Service that handle requests
import {ProductsService} from '../../services/products.service'


@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {
  myShoppingCart: Product[] = [];
  Total=0;
  products: Product[] = [];
  today = new Date();
  date = new Date(2021,1,21);


  constructor(
    private storeServices : StoreService,
    private  ProductsService: ProductsService
  ) {
    this.myShoppingCart = this.storeServices.getShoppingCart()
  }

  ngOnInit(): void {
    this.ProductsService.getAllProducts()
      .subscribe(data=>{
        this.products = data;
      });
  }

  onAddToShopingCart(product:Product){
    this.storeServices.addProduct(product);
    this.Total = this.storeServices.getTotal();
  }
}
