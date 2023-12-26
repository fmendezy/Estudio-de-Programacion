import { Component, OnInit } from '@angular/core';
import { Circulo,} from 'src/FiguraGeometrica';
import { IonicModule } from '@ionic/angular';
import { CommonModule } from '@angular/common';
import { IonImg, IonTitle, IonToolbar, IonHeader, IonItem,IonButton ,IonList, IonInput, IonSelect, IonText, IonContent, IonLabel, IonCard,} from '@ionic/angular/standalone';
import { FormsModule } from '@angular/forms';
import { Triangulo } from 'src/FiguraGeometrica';


@Component({
  selector: 'app-triangulo',
  templateUrl: './triangulo.component.html',
  styleUrls: ['./triangulo.component.scss'],
  standalone:true,
  imports: [IonImg, IonTitle, IonToolbar, IonHeader, IonItem, IonList, IonButton, IonInput, IonSelect, FormsModule, IonText, IonLabel, IonContent,IonCard]
})
export class TrianguloComponent implements OnInit {
  ladoAStr: string = "";
  ladoBStr: string = "";
  ladoCStr: string = "";
  resultado: string = "";

  CalcularPerimetro() {
    const ladoA = parseInt(this.ladoAStr);
    const ladoB = parseInt(this.ladoBStr);
    const ladoC = parseInt(this.ladoCStr);
    const triangulo = new Triangulo(0, ladoA, ladoB, ladoC);
    const perimetro = triangulo.calcularPerimetro();
    this.resultado = `El perímetro del triángulo es ${perimetro.toFixed(0)}`;
  }

  constructor() { }

  ngOnInit() { }
}