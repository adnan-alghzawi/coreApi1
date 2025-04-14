import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AdnanService {

  //https://localhost:7024/api/Product/getProducts
  //  https://localhost:7024/api/Category/getCateegories

  constructor(private _url: HttpClient) { }
  getProducts() {
    return this._url.get('https://localhost:7024/api/Product/getProducts');
  }
  getCategories() {
    return this._url.get('https://localhost:7024/api/Category/getCateegories');
  }
  addCategorries(data:any) {
    return this._url.post('https://localhost:7024/api/Category/addCategories',data);
  }
  editCategory(id:any , data:any) {
    return this._url.put(`https://localhost:7024/api/Category/updateCategory/${id}`,data);
  }
  deleteCategory(id: any) {
    return this._url.delete(`https://localhost:7024/api/Category/deleteCategory/${id}`);
  }


}
