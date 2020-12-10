import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';




@Injectable({
  providedIn: 'root'
})

export class ServiceService {
 
  constructor(private http: HttpClient) { }
   httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'json'
    })
  };
 
  getData() {
    //get all Employee data
    return this.http.get('/api/Employee');
    //https://nairamarley.azurewebsites.net/ webapi host url
  }

  postData(formData) {
    return this.http.post('/api/Employee', formData);
  }

  putData(id, formData) {
    return this.http.put('/api/Employee/' + id, formData);
  }
  deleteData(id) {
    return this.http.delete('/api/Employee/' + id);
  }

}  
