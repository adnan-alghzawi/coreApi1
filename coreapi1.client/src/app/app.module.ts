import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AllCategoriesComponent } from './all-categories/all-categories.component';
import { AllProductsComponent } from './all-products/all-products.component';
import { EditCategoryComponent } from './edit-category/edit-category.component';
//import { CategoryComponent } from './category/category.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    AllCategoriesComponent,
    AllProductsComponent,
    EditCategoryComponent,
    //CategoryComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
