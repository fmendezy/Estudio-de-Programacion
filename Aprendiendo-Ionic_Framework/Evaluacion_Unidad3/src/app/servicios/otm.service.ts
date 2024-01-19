import { Injectable } from '@angular/core';
import { resultadoWS, destinodetalleWS, destino } from '../data/mapeoWS';


@Injectable({
  providedIn: 'root'
})
export class OTMService {

  apiKey  = "5ae2e3f221c38a28845f05b6b54eb49eae423849ef81f8e9a658d59c"
  baseUrl = "https://api.opentripmap.com/0.1/en/" 

  constructor() { }

  async buscarDestino(termino: string): Promise<resultadoWS> { 
      const url = `${this.baseUrl}/places/autosuggest?name=${termino}&radius=12742000&lon=-33.5789368&lat=-70.5758399&rate=3&limit=5&apikey=${this.apiKey}`;
      const resultado = await fetch(url);
      const data = await resultado.json();
      return data;
  }
  
  async buscarImg(source: string): Promise<destinodetalleWS> {    
      const url = `${this.baseUrl}/places/xid/${source}?&apikey=${this.apiKey}`;
      const resultado = await fetch(url);
      const data = await resultado.json();
      return data;
     }
  }
  