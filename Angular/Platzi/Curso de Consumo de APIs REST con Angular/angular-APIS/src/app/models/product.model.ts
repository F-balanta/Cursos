export interface Category {
  id: string;
  title: string;
}

export interface Product {
  id: string;
  title: string;
  price: number;
  images: string[];
  description: string;
  category: Category;
}

export interface CreateProductDTO extends Omit<Product,'id' | 'category'>{
  categoryId: number;
}

export interface UpdateProductDTO extends Partial<CreateProductDTO> {}
