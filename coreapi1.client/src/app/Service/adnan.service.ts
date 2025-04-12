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

}
