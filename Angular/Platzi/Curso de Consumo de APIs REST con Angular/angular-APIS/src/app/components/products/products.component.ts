import { Component, OnInit } from '@angular/core';

import {CreateProductDTO, Product,UpdateProductDTO} from '../../models/product.model';

import { StoreService } from '../../services/store.service';
import { ProductsService } from '../../services/products.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {

  myShoppingCart: Product[] = [];
  total = 0;
  products: Product[] = [];
  showProductDetail = false;
  // Esta variable guardará el producto obtenido al darle click al boton //ver detalles
  productChosen: Product = {
    // Se le da un estado inicial ya que por el momento no tendra datos
    id: '',
    price: 0,
    images: [],
    title: '',
    category: {
      id: '',
      title: ''
    },
    description: ''
  };
  limit = 10;
  offset = 0

  constructor(
    private storeService: StoreService,
    private productsService: ProductsService
  ) {
    this.myShoppingCart = this.storeService.getShoppingCart();
  }

  ngOnInit(): void {
    // Get all products
    // Get all products
    //this.productsService.getProductsByPage(10,0)
    //  subscribe(data => {
    //      this.products = data;
    //  });
    this.loadMore();
  }

  onAddToShoppingCart(product: Product) {
    this.storeService.addProduct(product);
    this.total = this.storeService.getTotal();
  }

  toggleProductDetail(){
    this.showProductDetail = !this.showProductDetail;
  }
  onShowDetail(id: string){
    this.productsService.getProduct(id)
      .subscribe(data=>{
        // Se lanzara el modal solo cuando se reciba la información del producto
        this.toggleProductDetail();
        this.productChosen = data;
      })
  }

  CreateNewProduct(){
    const product: CreateProductDTO = {
      title: 'Nuevo Producto',
      description:'Bla bla bla',
      images:[''],
      price: 1000,
      categoryId: 2
    };
    this.productsService.create(product)
      .subscribe(data =>{
        // Agregará el nuevo producto al array de productos
        this.products.unshift(data)
      });
  }

  updateProduct(){
    const changes: UpdateProductDTO = {
      title: 'Titulo Actualizado',
      description: 'DescripcionActualizada',
      images: [''],
      price: 5000,
      categoryId: 1,
    };
    const id = this.productChosen.id;
    this.productsService.update(id,changes)
      .subscribe(data=>{
        const productIndex = this.products.findIndex(item => item.id === this.productChosen.id);
        this.products[productIndex] = data;
        this.productChosen = data;
      })
  }

  deleteProduct(){
    const id = this.productChosen.id;
    this.productsService.delete(id)
      .subscribe(()=>{
        // Index para saber cual de los productos se debe de eliminar
        const productIndex = this.products.findIndex(item => item.id === this.productChosen.id);
        this.products.splice(productIndex,1);
        this.showProductDetail = false;
      });
  }

  loadMore(){
    this.productsService.getProductsByPage(this.limit,this.offset)
      .subscribe(data => {
        this.products = this.products.concat((data));
        this.offset += this.limit;
      });
  }
}
