import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Administrators } from '../Types/administrators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AdministratorsService {

  constructor(private http:HttpClient) { }

  getadministrators=():Observable<Administrators[]> => this.http.get<Administrators[]>("https://localhost:7270/api/Administrator");

  addadministrator=(data:Administrators)=> this.http.post("https://localhost:7270/api/Administrator", data);
  
  updateadministrator=(Id:number, data:Administrators)=>this.http.put("https://localhost:7270/api/Administrator?Id="+Id, data);

  deleteadministrator=(id:number)=> this.http.delete("https://localhost:7270/api/Administrator?Id="+id);

  getadminmethod=(id:number):Observable<Administrators[]>=>this.http.get<Administrators[]>("https://localhost:7270/api/Administrator/"+id);
}
