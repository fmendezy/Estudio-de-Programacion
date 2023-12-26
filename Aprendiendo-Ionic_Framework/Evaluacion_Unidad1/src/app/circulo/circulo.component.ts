import { Component, OnInit } from '@angular/core';
import { Circulo } from 'src/FiguraGeometrica';
import { IonicModule } from '@ionic/angular';
import { CommonModule } from '@angular/common';
import { IonImg, IonItem,IonButton ,IonList, IonInput, IonSelect, IonText, IonContent, IonLabel} from '@ionic/angular/standalone';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-circulo',
  templateUrl: './circulo.component.html',
  styleUrls: ['./circulo.component.scss'],
  standalone: true,
  imports:  [IonImg, IonItem, IonList, IonButton, IonInput, IonSelect, FormsModule, IonText, IonLabel, IonContent]
})
export class CirculoComponent implements OnInit {

variableStr: string ="";
resultado: string = "";

CalcularPerimetro() {
  const variable = parseInt(this.variableStr)
  const circulo = new Circulo(variable)
  const perimetro = circulo.calcularPerimetro()
  this.resultado = `El perimetro del circulo es ${perimetro.toFixed(0)}`
}
  ngOnInit() {}
}
