import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from '../category/category.component';

@Injectable({
  providedIn: 'root'
})
export class AdnanService {

  constructor(private http : HttpClient) { }

  getAllCategories() {
    return this.http.get<Category[]>('https://localhost:7024/api/C1/getCategories');
  }
  
}
