import { Component } from '@angular/core';
import { AdnanService } from '../Service/adnan.service';
export interface Category {
  categoryId: number;
  categoryName: string;
  categoryDescription: string;
}

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrl: './category.component.css'
})



export class CategoryComponent {
  categoryList: Category[] = [];
  constructor(private ser: AdnanService) { }



  ngOnInit() {
    this.getCategories();
  }

  getCategories() {
    this.ser.getAllCategories().subscribe((data) => {
      this.categoryList = data;
    })
    
  }
}
