export abstract class FiguraGeometrica {
    variable:number 


    constructor(variable:number){
        this.variable = variable

    }
    abstract calcularPerimetro(): number
}

//Calculo perimetro del area

export class Circulo extends FiguraGeometrica{
    constructor (variable:number){
        super(variable)
    }
    
    override calcularPerimetro(): number {
        return 2 * Math.PI * this.variable;
    }
}


//Calculo Perimetro triangulo, se ocupa la misma formula para tanto escaleno como equilatero

export class Triangulo extends FiguraGeometrica{
    ladoA: number;
    ladoB: number;
    ladoC: number;

    constructor(variable: number, ladoA: number, ladoB: number, ladoC: number) {
        super(variable);
        this.ladoA = ladoA;
        this.ladoB = ladoB;
        this.ladoC = ladoC;
      }
    
    override calcularPerimetro(): number {
        return this.ladoA + this.ladoB + this.ladoC;
    }
}

