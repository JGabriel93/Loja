import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {

  public logoEmpresa = "/assets/empresa/logo.png";

  public usuario;
  public autenticado: boolean;
  constructor() {
    this.usuario = new Usuario();
  }

  entrar() {
    if (this.usuario.email == "joao@teste.com.br" && this.usuario.senha == "123")
      this.autenticado = true;
  }
}
