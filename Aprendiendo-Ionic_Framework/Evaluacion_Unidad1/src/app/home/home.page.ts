import { Component } from '@angular/core';
import { IonImg, IonItem, IonList, IonHeader, IonToolbar, IonTitle, IonContent, IonSelect, IonSelectOption, SelectChangeEventDetail } from '@ionic/angular/standalone';
import { CirculoComponent } from '../circulo/circulo.component';
import { FigurageometricaComponent } from '../figurageometrica/figurageometrica.component';
import { TrianguloComponent } from '../triangulo/triangulo.component';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { IonSelectCustomEvent } from '@ionic/core';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
  standalone: true,
  imports: [IonImg, FormsModule, CommonModule, IonItem, IonList, IonHeader, IonToolbar, IonTitle, IonContent,CirculoComponent, FigurageometricaComponent, TrianguloComponent, IonSelect, IonSelectOption],
})
export class HomePage {
handlechange($event: IonSelectCustomEvent<SelectChangeEventDetail<any>>) {
  this.componente = $event.detail.value
}

  componente:string = ""
  
  constructor() {}

  InfoCirculo():boolean {
    return this.componente == "circulo"
  }
  
  InfoTriangulo():boolean {
    return this.componente == "triangulo"
  }
}
