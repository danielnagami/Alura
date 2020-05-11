import { Component } from '@angular/core';
import { markDirtyIfOnPush } from '@angular/core/src/render3/instructions';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'alurapic';
  description = "Frango";
  url = "https://certifiedhumanebrasil.org/wp-content/uploads/2017/05/Bem-estar-animal-para-frangos-de-corte.jpg";
}