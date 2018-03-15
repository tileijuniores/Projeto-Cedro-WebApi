import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { CasdastroRestauranteComponent } from './Cadastro/casdastro-restaurante/casdastro-restaurante.component';
import { CasdastroPratoComponent } from './Cadastro/casdastro-prato/casdastro-prato.component';
import { HomeComponent } from './home/home.component';
import { ConsultaPratosComponent } from './Consulta/consulta-pratos/consulta-pratos.component';
import { ConsultaRestaurantesComponent } from './Consulta/consulta-restaurantes/consulta-restaurantes.component';
import { ServicosComponent } from './servicos/servicos.component';


@NgModule({
  declarations: [
    AppComponent,
    CasdastroRestauranteComponent,
    CasdastroPratoComponent,
    HomeComponent,
    ConsultaPratosComponent,
    ConsultaRestaurantesComponent,
    ServicosComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
