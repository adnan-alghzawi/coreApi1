import { Component } from '@angular/core';
import { AdnanService } from '../service/adnan.service';

@Component({
  selector: 'app-all-categories',
  templateUrl: './all-categories.component.html',
  styleUrl: './all-categories.component.css'
})
export class AllCategoriesComponent {
  constructor(private _ser: AdnanService) { }

  ngOnInit() {
    this.getAllCategories();
  }

  container: any;

  getAllCategories() {
    this._ser.getCategories().subscribe((data: any) => {
      this.container = data;

    })
  }

}
