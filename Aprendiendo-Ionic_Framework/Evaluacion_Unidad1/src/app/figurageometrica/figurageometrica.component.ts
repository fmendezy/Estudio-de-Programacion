import { Component, OnInit } from '@angular/core';
import { IonItem, IonList, IonInput, IonSelect, IonSelectOption, IonButton } from '@ionic/angular/standalone';
import { TrianguloComponent } from '../triangulo/triangulo.component';
import { CirculoComponent } from '../circulo/circulo.component';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-figurageometrica',
  templateUrl: './figurageometrica.component.html',
  styleUrls: ['./figurageometrica.component.scss'],
  standalone: true,
  imports: [IonList, IonItem, IonInput, IonSelect, IonSelectOption,TrianguloComponent, CirculoComponent ]
})
export class FigurageometricaComponent implements OnInit {

  constructor() { }

  ngOnInit() {}
  

}
